using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    internal class usedProduct:Product
    {
        public DateTime ManufactureDate { get; set; }
        public usedProduct()
        {

        }
        public usedProduct(string name, double price, DateTime manufactureDate):base(name,price)
        {
            ManufactureDate = manufactureDate;
        }
        public override string PriceTag()
        {
            Name += " (used)";
            return base.PriceTag() + "(Manufacture date:"+ManufactureDate.ToString("dd/MM/yyyy")+")";
        }
    }
}
