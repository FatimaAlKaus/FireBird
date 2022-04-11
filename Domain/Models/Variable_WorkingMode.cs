using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Variable_WorkingMode : Entity
    {
        public Variable Variable { get; set; } = null!;
        public int VariableId { get; set; }
        public WorkingMode WorkingMode { get; set; } = null!;
        public int WorkingModeId { get; set; }
        public decimal RequiredValue { get; set; }
    }
}
