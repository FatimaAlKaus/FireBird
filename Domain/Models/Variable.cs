using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Variable : Entity
    {
        public string Name { get; set; } = default!;
        public decimal Value { get; set; }
        public ExternalVariable? RealSource { get; set; }
        public GeneratingTE? GTO { get; set; }
        public ICollection<Script> Script { get; set; } = null!;
        public ICollection<Variable_WorkingMode> Variable_WorkingModes { get; set; } = null!;

    }
}
