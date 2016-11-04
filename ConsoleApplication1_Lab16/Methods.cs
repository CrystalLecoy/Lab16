using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1_Lab16
{
    class Methods
    {
        public void isAPrime (long LengthOfPrimeNumbersMax)
        {
            List<long> PrimeNumbers = new List<long>();

            int i = 0;
            do
            {
                bool isPrime = true;
                for (long j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    PrimeNumbers.Add(i);
                }
                i++;
            } while (PrimeNumbers.Count < LengthOfPrimeNumbersMax+2);
            Console.WriteLine($"The number {LengthOfPrimeNumbersMax} prime is: {PrimeNumbers[(int)LengthOfPrimeNumbersMax - 1+2]}");

        }
    }
}
