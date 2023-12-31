﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWTest
{
    public class Calculator
    {
        static public double Addition(double num1, double num2)
        {
            return num1 + num2;
        }
        static public double Difference(double num1, double num2)
        {
            return num1 - num2;
        }
        static public double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }
        static public double AdditionPrice(List<Product> products)
        {
            double result = 0;
            foreach (Product product in products) { 
                result += product.Price;
            }
            return result;
        }
        static public double DiscountUse(double priceBuy,int discountPercent)
        {
            return (priceBuy - (priceBuy/100)* discountPercent);
        }
    }
}
