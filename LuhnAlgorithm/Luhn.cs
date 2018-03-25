using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuhnAlgorithm
{
    class Luhn
    {
        public void CheckNumber(string strnumber)
        {
            int length = strnumber.Length;
            int sum = 0;

            char[] CCNArray = strnumber.ToCharArray();
            Array.Reverse(CCNArray);

            int[] CCNnumber = Array.ConvertAll(CCNArray, x => (int) Char.GetNumericValue(x));

            for (int i = 0; i < length; i++)
            {
                if (i % 2 == 0)
                    CCNnumber[i] = CCNnumber[i] * 1;
                else
                    CCNnumber[i] = CCNnumber[i] * 2;

                if (CCNnumber[i] > 9)
                    CCNnumber[i] = CCNnumber[i] - 9;

                sum += CCNnumber[i];
            }

            if (sum % 10 == 0)
                Console.WriteLine("Valid credit card number");
            else
                Console.WriteLine("Not valid credit card number");
        }
    }
}
