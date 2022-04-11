using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ExternalVariable : Entity
    {
        public string Name { get; set; } = default!;
        public ExternalSourceConnection ExternalConnection { get; set; } = null!;
        public int ExternalConnectionId { get; set; }
    }
}
