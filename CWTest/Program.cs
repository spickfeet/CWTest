using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWTest
{
    public enum TransactionMethod
    {
        Card,
        Cash,
        SBP
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyInCashRegister = 10000;
            List<Product> productInAssortment = new List<Product>();
            List<Product> productsBuy = new List<Product>();
            List<Product> productsBuy1 = new List<Product>();
            Product product1 = new Product(110011,"Сок добрый 1Л", 99, new DateTime(2024, 10, 10));
            Product product2 = new Product(119901, "Сыр", 105, new DateTime(2024, 12, 11));
            Product product3 = new Product(133301, "Молоко 1Л", 79, new DateTime(2023, 12, 11));
            Product product4 = new Product(197801, "Чипсы", 56, new DateTime(2023, 10, 15));
            Product product5 = new Product(219901, "Шоколад", 105, new DateTime(2023, 12, 26));

            productInAssortment.Add(product1);
            productInAssortment.Add(product2);
            productInAssortment.Add(product3);
            productInAssortment.Add(product4);
            productInAssortment.Add(product5);

            Console.WriteLine("Деньги в кассе: " + moneyInCashRegister);

            foreach (Product product in productInAssortment)
            {
                if(product.ProductID == 110011|| product.ProductID == 133301 || product.ProductID == 219901 || product.ProductID == 119901) productsBuy.Add(product);
            }

            Buy buy1 = new Buy(TransactionMethod.Card, Calculator.AdditionPrice(productsBuy), "Мария В.", productsBuy, 13123, 10);

            buy1.DiscountHave();
            Console.WriteLine( "Метод оплаты: " +buy1.TransactionMethod + "\nСкидка: " + buy1.Discount + " %" 
                + "\nЦена с учетом скидки: " + buy1.MoneyAmount + " руб" + "\nID заказа: " + buy1.BuyID + "\nПродавец: " + buy1.СashierrName + "\n---Список продуктов---");
           
            foreach(Product product in buy1.ProductsList)
            {
                Console.WriteLine(product.ProductID + "\n" + product.Name + "\n" + product.Price + "\n" + product.Exdate + "\n");
            }
            moneyInCashRegister = buy1.ChangeMoneyInCashRegister(moneyInCashRegister);
            Console.WriteLine("Деньги в кассе: " + moneyInCashRegister);

            Console.WriteLine("Ассортимент");

            buy1.RemuveProductsInAssortment(productInAssortment);

            foreach (Product product in productInAssortment)
            {
                Console.WriteLine(product.ProductID + "\n" + product.Name + "\n" + product.Price + "\n" + product.Exdate + "\n");
            }
        }
    }
}
