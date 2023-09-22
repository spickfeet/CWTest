using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWTest
{
    public enum TransactionMetod
    {
        Card,
        Cash,
        SBP
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> productRange = new List<Product>();
            List<Product> productsBuy = new List<Product>();
            Product product1 = new Product(110011,"Сок добрый 1Л", 99, new DateTime(2024, 10, 10));
            Product product2 = new Product(119901, "Сыр", 105, new DateTime(2024, 12, 11));
            Product product3 = new Product(133301, "Молоко 1Л", 79, new DateTime(2023, 12, 11));
            Product product4 = new Product(197801, "Чипсы", 56, new DateTime(2023, 10, 15));
            Product product5 = new Product(219901, "Шоколад", 105, new DateTime(2023, 12, 26));

            productRange.Add(product1);
            productRange.Add(product2);
            productRange.Add(product3);
            productRange.Add(product4);
            productRange.Add(product5);

            foreach(Product product in productsBase)
            {
                if(product.ProductID == 110011|| product.ProductID == 133301 || product.ProductID == 219901 || product.ProductID == 119901) productsBuy.Add(product);
            }

            Buy buy1 = new Buy(PayMetod.Card, 15, Calculator.AdditionPrice(productsBuy), 13123, "Мария В.", productsBuy);
            
            buy1.DiscountHave();
            Console.WriteLine( "Метод оплаты: " +buy1.PayMetod + "\nСкидка: " + buy1.Discount + " %" 
                + "\nЦена с учетом скидки: " + buy1.PriceBuy + " руб" + "\nID заказа: " + buy1.BuyID + "\nПродавец: " + buy1.SellerName + "\n---Список продуктов---");
            foreach(Product product in Buy.ProductsList)
            {
                Console.WriteLine(product.ProductID + "\n" + product.Name + "\n" + product.Price + "\n" + product.Exdate + "\n");
            }
        }
    }
}
