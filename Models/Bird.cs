using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poultrymanagement_0.Models
{
    public class Bird
    {
        public int Id {get;set;}
        public string Breed { get; set; }
        public double Weight { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsSold { get; set; }
        public bool IsSick { get; set; }
        public bool ReadForSale { get; set; }
        public DateTime DateSold { get; set; }
        public decimal Price { get; set; }
    }
}