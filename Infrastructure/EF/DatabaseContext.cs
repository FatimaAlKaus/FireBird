using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EF
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<CalculationData> CalculationDatas => Set<CalculationData>();
        public DbSet<DriverType> DriverTypes => Set<DriverType>();
        public DbSet<EnergyType> EnergyTypes => Set<EnergyType>();
        public DbSet<ExternalSourceConnection> ExternalSources => Set<ExternalSourceConnection>();
        public DbSet<ExternalVariable> ExternalVariables => Set<ExternalVariable>();
        public DbSet<GeneratingTE> GeneratingTEs => Set<GeneratingTE>();
        public DbSet<GTE_Property> GTE_Properties => Set<GTE_Property>();
        public DbSet<GTE_Type> GTE_Types => Set<GTE_Type>();
        public DbSet<Property> Properties => Set<Property>();
        public DbSet<Script> Scripts => Set<Script>();
        public DbSet<TechnologicalNode> TechnologicalNodes => Set<TechnologicalNode>();
        public DbSet<TN_Property> TN_Properties => Set<TN_Property>();
        public DbSet<Variable> Variables => Set<Variable>();
        public DbSet<Variable_WorkingMode> Variable_WorkingModes => Set<Variable_WorkingMode>();
        public DbSet<WorkingMode> WorkingModes => Set<WorkingMode>();
        public DbSet<GTE_TN> GTE_TN => Set<GTE_TN>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GTE_TN>()
        .HasKey(bc => new { bc.Id, bc.GTE_Id, bc.TN_Id });
            modelBuilder.Entity<GTE_TN>()
                .HasOne(bc => bc.GeneratingTE)
                .WithMany(b => b.GTE_TNs)
                .HasForeignKey(bc => bc.GTE_Id);
            modelBuilder.Entity<GTE_TN>()
                .HasOne(bc => bc.TechnologicalNode)
                .WithMany(c => c.GTE_TNs)
                .HasForeignKey(bc => bc.TN_Id);

            modelBuilder.Entity<CalculationData>()
                .HasOne(x => x.WorkingMode)
                .WithMany(x => x.CalculationData)
                .HasForeignKey(x => x.WorkingMode_Id)
                .IsRequired();

            modelBuilder.Entity<ExternalSourceConnection>()
                .HasOne(x => x.DriverType)
                .WithMany(x => x.Connections)
                .HasForeignKey(x => x.DriverTypeId)
                .IsRequired();

            modelBuilder.Entity<ExternalVariable>()
                .HasOne(x => x.ExternalConnection)
                .WithMany(x => x.ExternalVariables)
                .HasForeignKey(x => x.ExternalConnectionId)
                .IsRequired();

            modelBuilder.Entity<GeneratingTE>()
                .HasOne(x => x.WorkingMode)
                .WithMany(x => x.GeneratingTEs)
                .HasForeignKey(x => x.WorkingModeId)
                .IsRequired();

            modelBuilder.Entity<GeneratingTE>()
                .HasOne(x => x.Type)
                .WithMany(x => x.GeneratingTEs)
                .HasForeignKey(x => x.GTE_TypeId)
                .IsRequired();

            modelBuilder.Entity<GTE_Property>()
                .HasOne(x => x.GeneratingTE)
                .WithMany(x => x.GTE_Properties)
                .HasForeignKey(x => x.GeneratingTE_Id)
                .IsRequired();

            modelBuilder.Entity<GTE_Property>()
                .HasOne(x => x.Property)
                .WithMany(x => x.GTE_Properties)
                .HasForeignKey(x => x.PropertyId)
                .IsRequired();

            modelBuilder.Entity<TechnologicalNode>()
                .HasOne(x => x.TN_Type)
                .WithMany(x => x.TechnologicalNodes)
                .HasForeignKey(x => x.TN_TypeId)
                .IsRequired();

            modelBuilder.Entity<TechnologicalNode>()
                .HasOne(x => x.EnergyType)
                .WithMany(x => x.TechnologicalNodes)
                .HasForeignKey(x => x.EnergyTypeId)
                .IsRequired();

            modelBuilder.Entity<TN_Property>()
                .HasOne(x => x.TechnologicalNode)
                .WithMany(x => x.TN_Properties)
                .HasForeignKey(x => x.TechnologicalNodeId)
                .IsRequired();

            modelBuilder.Entity<TN_Property>()
               .HasOne(x => x.Property)
               .WithMany(x => x.TN_Properties)
               .HasForeignKey(x => x.PropertyId)
               .IsRequired();

            modelBuilder.Entity<Variable_WorkingMode>()
                .HasOne(x => x.WorkingMode)
                .WithMany(x => x.Variable_WorkingModes)
                .HasForeignKey(x => x.WorkingModeId)
                .IsRequired();

            modelBuilder.Entity<Variable_WorkingMode>()
                .HasOne(x => x.Variable)
                .WithMany(x => x.Variable_WorkingModes)
                .HasForeignKey(x => x.VariableId)
                .IsRequired();
        }
    }
}
