using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Створити 3 класа. Перший клас User містить закриті поля id, username, password, address.
// Створіть відповідні їм властивості, запис в поля можна робити тільки через властивості та лише в середині цього класу.
// Створіть конструктор, який буде ініціалізувати поля класа через властивості.
// Клас Product має полі id name price description. Створити відповідні властивості та конструктор,
// який буде ініціалізувати ці поля як і в класі User. Створіть клас Order.
// Клас має поле orderId, User та список продуктів. Створити їм відповідні властивості та конструктор з 2 параметрами.
// В конструкторі необхідно виділяти пам'ять для списка продуктів. Реалізуйте метод AddProduct,
// який приймає в якості параметра продукт, даний метод має в список добавляти переданий продукт.
// Реалізуйте метод Calculate, який буде повертати загальну ціну для всіх продуктів цього заказу.
// В мейні створіть 3 користувача та 5 продуктів. Зробіть так щоб перший користувач зробив 2 замовлення,
// другий користувач зробив 4 замовлення, а третій користувач – 6 замовлень. Виведіть інформацію про користувача,
// який замовив на найбільшу суму та виведіть всі товари які він замовив

namespace HomeWork_12_2_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User Vadym = new User(1, "Vadym", "qwerty", "Ukraine");
            User Irina = new User(2, "Irina", "qwerty", "USA");
            User Tanya = new User(3, "Tanya", "qwerty", "Poland");

            Product meat = new Product(1, "Meat", 200, "Chicken");
            Product milk = new Product(2, "Milk", 30, "Burenka");
            Product tomato = new Product(3, "Tomato", 80, "Tomato branch");
            Product cucumber = new Product(4, "Cucumber", 70, "Greenhouse Cucumber");
            Product potato = new Product(5, "Potato", 20, "White Potatoes");

            // Vadym
            Order order_1 = new Order(1, Vadym);
            order_1.AddProduct(meat);
            order_1.AddProduct(milk);

            Order order_2 = new Order(2, Vadym);
            order_2.AddProduct(tomato);
            order_2.AddProduct(potato);
            // Irina
            Order order_3 = new Order(3, Irina);
            order_3.AddProduct(meat);
            order_3.AddProduct(milk);
            order_3.AddProduct(tomato);
            order_3.AddProduct(potato);

            Order order_4 = new Order(4, Irina);
            order_4.AddProduct(meat);
            order_4.AddProduct(potato);
            order_4.AddProduct(cucumber);

            Order order_5 = new Order(5, Irina);
            order_5.AddProduct(tomato);
            order_5.AddProduct(potato);
            order_5.AddProduct(milk);

            Order order_6 = new Order(6, Irina);
            order_6.AddProduct(tomato);
            order_6.AddProduct(potato);
            order_6.AddProduct(meat);
            order_6.AddProduct(milk);
            // Tanya
            Order order_7 = new Order(7, Tanya);
            order_7.AddProduct(meat);
            order_7.AddProduct(milk); ;
            order_7.AddProduct(potato);

            Order order_8 = new Order(8, Tanya);
            order_8.AddProduct(meat);
            order_8.AddProduct(potato);
            order_8.AddProduct(cucumber);

            Order order_9 = new Order(9, Tanya);
            order_9.AddProduct(tomato);
            order_9.AddProduct(potato);
            order_9.AddProduct(milk);

            Order order_10 = new Order(10, Tanya);
            order_10.AddProduct(tomato);
            order_10.AddProduct(milk);

            Order order_11 = new Order(11, Tanya);
            order_11.AddProduct(tomato);
            order_11.AddProduct(meat);
            order_11.AddProduct(milk);

            Order order_12 = new Order(12, Tanya);
            order_12.AddProduct(tomato);
            order_12.AddProduct(potato);

            List<Order> orderList = new List<Order>()
            {
                order_1,
                order_2,
                order_3,
                order_4,
                order_5,
                order_6,
                order_7,
                order_8,
                order_9,
                order_10,
                order_11,
                order_12,
            };

            Dictionary<User, float> usersOrdersTotalSumm = CalcMaxCostOrders(orderList); // получаю Словарь с Пользователем и общей суммой его покупок
            User maxRichUser = ReturnMostReachUser(usersOrdersTotalSumm); // получаю пользователя с самой большой продуктовой корзиной
            List<Order> currentOrders = CalcOrdersMostReachPerson(orderList, maxRichUser); // получаю все заказы Пользователя с самой большой продуктовой корзиной

            maxRichUser.Print();
            float totalCost = 0;

            foreach (Order order in currentOrders)
            {
                order.ShowOrderProducts();
                totalCost += order.Calculate();

            }

            Console.WriteLine(totalCost);


        }
        static Dictionary<User, float> CalcMaxCostOrders(List<Order> orders)
        {
            Dictionary<User, float> userInfo = new Dictionary<User, float>();

            foreach (Order order in orders)
            {
                float orderCost = order.Calculate();// тут считаем сумму каждого заказа

                if (!userInfo.ContainsKey(order.User)) // если в Словаре нет ключа,
                {
                    userInfo[order.User] = 0; // то создаем его и присваиваем значение 0, тем самым мы создали ключ и его значение
                }
                userInfo[order.User] += orderCost; // далее прибавляем 
            }

            return userInfo;
        }

        static List<Order> CalcOrdersMostReachPerson(List<Order> orders, User user)
        {
            List<Order> currentOrders = new List<Order>();
            foreach (var order in orders)
            {
                if (order.User == user)
                {
                    currentOrders.Add(order);
                }
            }
            return currentOrders;
        }



        static User ReturnMostReachUser(Dictionary<User, float> maxRichUser)
        {
            float totalCost = 0;
            User user = null;
            foreach (var usr in maxRichUser)
            {
                if (usr.Value > totalCost)
                {
                    totalCost = usr.Value;
                    user = usr.Key;
                }
            }
            return user;
        }
    }
}

