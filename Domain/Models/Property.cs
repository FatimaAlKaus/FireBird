using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Property : Entity
    {
        public string Name { get; set; } = default!;
        public ICollection<GTE_Property> GTE_Properties { get; set; } = null!;
        public ICollection<TN_Property> TN_Properties { get; set; } = null!;
    }
}
