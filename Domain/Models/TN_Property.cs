using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class TN_Property : Entity
    {
        public TechnologicalNode TechnologicalNode { get; set; } = null!;
        public int TechnologicalNodeId { get; set; }
        public Property Property { get; set; } = null!;
        public int PropertyId { get; set; }
        public decimal Value { get; set; }
        public Variable? Variable { get; set; }
    }
}
