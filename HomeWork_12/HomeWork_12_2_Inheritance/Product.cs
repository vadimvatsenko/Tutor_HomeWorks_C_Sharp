using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12_2_Inheritance
{
    internal class Product
    {
        private int productId;
        private string productName;
        private int priceProduct;
        private string productDescription;

        public int ProductId
        {
            get { return productId; }
            private set { productId = value; }
        }

        public string ProductName
        {
            get { return productName; }
            private set { productName = value; }
        }

        public int PriceProduct
        {
            get { return priceProduct; }
            private set { priceProduct = value; }
        }

        public string ProductDescription
        {
            get { return productDescription; }
            private set { productDescription = value; }
        }

        public Product(int id, string name, int price, string description)
        {
            ProductId = id;
            ProductName = name;
            PriceProduct = price;
            ProductDescription = description;
        }


    }
}
