using System;

namespace BuisnessCardLib
{
    public class BuisnessCard
    {
        protected double amount { get; set; }

        public BuisnessCard(double sum) {
            this.amount = sum;
        }

        public double info() {
            return this.amount;
        }
    }
}
