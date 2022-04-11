using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class CalculationData : Entity
    {
        public WorkingMode WorkingMode { get; set; }
        public int WorkingMode_Id { get; set; }
        public decimal Consumption { get; set; }
        public decimal HeatQuantity { get; set; }
        public decimal Wattage { get; set; }
        public decimal B => Consumption;
        public decimal Q => HeatQuantity;
        public decimal N => Wattage;
    }
}
