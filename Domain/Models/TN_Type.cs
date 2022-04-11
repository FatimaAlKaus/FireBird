﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class TN_Type : Entity
    {
        public string Name { get; set; } = default!;
        public ICollection<TechnologicalNode> TechnologicalNodes { get; set; } = null!;
    }
}
