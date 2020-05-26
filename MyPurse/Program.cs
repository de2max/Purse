using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyLib;
using CreditCardLib;

using BuisnessCardLib;

namespace MyPurse
{
    class Program
    {
        static void Main(string[] args)
        {
            Money sum = new Money(102.45);
            Console.WriteLine(sum.info());

            CreditCard creditCard = new CreditCard(12312);
            Console.WriteLine(creditCard.info());

            BuisnessCard buisnessCard = new BuisnessCard(3333);
            Console.WriteLine(buisnessCard.info());

            Console.ReadKey();
        }
    }
}
