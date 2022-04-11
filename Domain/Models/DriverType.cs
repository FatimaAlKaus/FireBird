using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class DriverType : Entity
    {
        public string Name { get; set; } = default!;
        public ICollection<ExternalSourceConnection> Connections { get; set; } = null!;
    }
}
