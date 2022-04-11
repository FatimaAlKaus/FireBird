using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class EnergyType : Entity
    {
        public string Name { get; set; } = default!;
        public ICollection<TechnologicalNode> TechnologicalNodes { get; set; } = null!;
    }
}
