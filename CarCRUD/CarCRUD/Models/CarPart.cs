using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace CarCRUD.Models
{
    public class CarPart
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Details { get; set; }

        public string StringPrice()
        {
            var nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";
            return Price.ToString(nfi);
        }
        public string Test { get; set; }
    }
    
}
