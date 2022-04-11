using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class TechnologicalNode : Entity
    {
        public string Name { get; set; } = default!;

        public TN_Type TN_Type { get; set; } = null!;
        public int TN_TypeId { get; set; }

        public EnergyType EnergyType { get; set; } = null!;
        public int EnergyTypeId { get; set; }
        public ICollection<GTE_TN> GTE_TNs { get; set; } = null!;
        public ICollection<TN_Property> TN_Properties { get; set; } = null!;
    }
}
