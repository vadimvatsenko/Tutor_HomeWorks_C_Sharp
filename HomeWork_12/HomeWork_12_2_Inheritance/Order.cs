using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12_2_Inheritance
{
    internal class Order
    {

        private int orderId;
        private User user;
        private List<Product> products;

        public int OrderId
        {
            get { return orderId; }
            private set { orderId = value; }
        }

        public User User
        {
            get { return user; }
            private set { user = value; }
        }

        public List<Product> Products
        {
            get { return products; }
            private set { products = value; }
        }

        public Order(int id, User user)
        {
            OrderId = id;
            User = user;
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public float Calculate()
        {
            float totalPrice = 0;
            foreach (Product product in Products)
            {
                totalPrice += product.PriceProduct;
            }

            return totalPrice;
        }

        public void ShowOrderProducts()
        {
            foreach (Product product in Products)
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
