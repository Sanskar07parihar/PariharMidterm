using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PariharMidterm.Models
{
    public class Laptop
    {
        public int LaptopId { get; set; }
        public string Processor { get; set; }
        public int RAM { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public DateTime DeliveryDate { get; set; }
        public double Total { get; set; }
    }
}
