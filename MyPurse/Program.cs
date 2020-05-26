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

            BuisnessCard buisnessCard = new BuisnessCard(3333);
            Console.WriteLine(bcard.info());


            CreditCard creditCard = new CreditCard(12312);
            Console.WriteLine(creditCard.info());

            Money sum = new Money(102.45);
            Console.WriteLine(sum.info());

            Console.ReadKey();
        }
    }
}
