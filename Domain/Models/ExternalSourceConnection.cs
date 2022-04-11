using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ExternalSourceConnection : Entity
    {
        public DriverType DriverType { get; set; } = null!;
        public int DriverTypeId { get; set; }
        public string ConnectionString { get; set; } = default!;
        public ICollection<ExternalVariable> ExternalVariables { get; set; } = null!;
    }
}
