using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class GTE_TN : Entity
    {
        public int GTE_Id { get; set; }
        public int TN_Id { get; set; }
        public GeneratingTE GeneratingTE { get; set; }
        public TechnologicalNode TechnologicalNode { get; set; }
    }
}
