using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class GTE_Type : Entity
    {
        public string Name { get; set; } = default!;
        public ICollection<GeneratingTE> GeneratingTEs { get; set; } = null!;
    }
}
