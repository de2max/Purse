using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyLib;
using CreditCardLib;


namespace MyPurse
{
    class Program
    {
        static void Main(string[] args)
        {
            Money sum = new Money(100.00);
            Console.WriteLine(sum.info());

            CreditCard cCard = new CreditCard(10123130);
            Console.WriteLine(cCard.info());

            Console.ReadKey();
        }
    }
}
