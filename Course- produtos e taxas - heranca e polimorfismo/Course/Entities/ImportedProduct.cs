using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    internal class ImportedProduct:Product
    {
        public Double CustomsFee { get; set; }
        public ImportedProduct()
        {

        }
        public ImportedProduct(string name, double price, double customsfee) : base(name, price)
        {
            CustomsFee = customsfee;
        }
        public double TotalPrice()
        {
            Price += CustomsFee;
            return Price;
        }
        public override string PriceTag()
        {
            TotalPrice();
            return base.PriceTag() + "(Customs fee: $"+CustomsFee+")";
        }
    }
}
