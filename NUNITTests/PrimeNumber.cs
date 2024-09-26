using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumTraining.NUNITTests
{
    internal class PrimeNumber
    {
        public bool IsPrime(int num)
        {
            if (num == 1) return false; // 1 is not prime
            if (num == 2) return true;  // 2 is prime

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false; // Not a prime number
                }
            }
            return true;
        }
    }
}
