using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Euler12
    {

        public static long Run(int divisorsNum) {
            long results = 0;
            int i = 1;

            while (NumberOfDivisors(results) < divisorsNum)
            {
                results += i;
                i++;
            }
            return results;
        }


        public static int NumberOfDivisors(long number)
        {
            int nod = 0;
            int sqrt = (int)Math.Sqrt(number);

            for (int i = 1; i <= sqrt; i++)
            {
                if (number % i == 0)
                {
                    nod += 2;
                }
            }
            //Correction if the number is a perfect square
            if (sqrt * sqrt == number)
            {
                nod--;
            }

            return nod;
        }
    }
}
