using System;

namespace MoneyLib
{
    public class Money
    {
        protected double amount { get; set; }

        public Money(double num)
        {
            this.amount = num;
        }

        public double info()
        {
            return this.amount;
        }
    }
}
