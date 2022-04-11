using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class GeneratingTE : Entity
    {
        public GTE_Type Type { get; set; } = null!;
        public int GTE_TypeId { get; set; }
        public string Name { get; set; } = default!;
        public decimal ThermalOutput { get; set; }
        public decimal ElectricalOutput { get; set; }
        public WorkingMode WorkingMode { get; set; } = null!;
        public int WorkingModeId { get; set; }
        public ICollection<GTE_TN> GTE_TNs { get; set; } = null!;
        public ICollection<GTE_Property> GTE_Properties { get; set; } = null!;
    }
}
