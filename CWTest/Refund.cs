﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWTest
{
    public class Refund : Transaction
    {
        private string _reasonRefound;
        public string ReasonRefound { get { return _reasonRefound; } set { _reasonRefound = value; } }
        public Refund(TransactionMethod transactionMetod, double moneyAmount, string cashierrName, string reasonRefound)
         : base(transactionMetod, moneyAmount, cashierrName)
        {
            TransactionMethod = transactionMetod;
            MoneyAmount = moneyAmount;
            СashierrName = cashierrName;
            ReasonRefound = reasonRefound;
        }
        override public double ChangeMoneyInCashRegister(double moneyInCashRegister)
        {
            return Calculator.Difference(moneyInCashRegister, MoneyAmount);
        }
    }

}
