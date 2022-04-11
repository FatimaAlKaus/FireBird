using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class WorkingMode : Entity
    {
        public string Name { get; set; } = default!;
        public ICollection<CalculationData> CalculationData { get; set; } = null!;
        public ICollection<GeneratingTE> GeneratingTEs { get; set; } = null!;
        public ICollection<Variable_WorkingMode> Variable_WorkingModes { get; set; } = null!;
    }
}
