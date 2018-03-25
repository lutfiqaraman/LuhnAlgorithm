using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuhnAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dummy credit card number : 3379 5135 6110 8795
            string CCN  = "3379513561108795";

            Luhn number = new Luhn();
            number.CheckNumber(CCN);

            Console.ReadKey();
        }
    }
}
