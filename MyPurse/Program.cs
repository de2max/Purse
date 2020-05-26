using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyLib;


namespace MyPurse
{
    class Program
    {
        static void Main(string[] args)
        {
            Money sum = new Money(100.00);
            Console.WriteLine(sum.info());

            Console.ReadKey();
        }
    }
}
