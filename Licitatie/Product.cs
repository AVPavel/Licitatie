using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licitatie
{
    public class Product
    {
        public string productName { get; set; }
        public double initialPrice { get; set; }
        public string otherInfo { get; set; }
        public bool isAvailable { get; set; }

        public Product(string productname, double initialprice, string otherinfo, bool isavailable)
        {
            this.productName = productname;
            this.initialPrice = initialprice;
            this.otherInfo = otherinfo;
            this.isAvailable = isavailable;
        }
        public Product()
        {

        }
    }
}
