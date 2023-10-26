using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWTest
{
    public class ProductWeight : Product
    {
        private double _weight;
        public double Weight { get { return _weight; } set { _weight = value; } }
        public ProductWeight(int productID, string name, double price, DateTime exdate, double weight):base(productID, name, price, exdate)
        {
            ProductID = productID;
            Name = name;
            Price = price;
            Exdate = exdate;
        }
    }
}
