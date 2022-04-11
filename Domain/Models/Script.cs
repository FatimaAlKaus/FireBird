using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Script : Entity
    {
        public string Description { get; set; } = default!;
        public string Body { get; set; } = default!;
        public List<Variable> Variable { get; set; } = null!;
    }
}
