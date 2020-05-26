using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuisnessCardLib;

namespace MyPurse
{
    class Program
    {
        static void Main(string[] args)
        {
            BuisnessCard bcard = new BuisnessCard(101);

            Console.WriteLine(bcard.info());

            Console.ReadKey();
        }
    }
}
