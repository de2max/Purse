using System;

namespace CreditCardLib
{
    public class CreditCard
    {
        protected double amount { get; set; }

        public CreditCard(double sum)
        {
            this.amount = sum;
        }

        public double info()
        {
            return this.amount;
        }
    }
}
