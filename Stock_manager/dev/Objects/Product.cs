using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_manager.dev.Objects
{
    class Product
    {
        private int stockCode;
        private string scope;
        private string type;
        private string brand;
        private string model;
        private int count;
        private double price;

        public Product(string scope, string type, string brand, string model, double price)
        {
            this.scope = scope;
            this.type = type;
            this.brand = brand;
            this.model = model;
            this.price = price;
        }
    }
}
