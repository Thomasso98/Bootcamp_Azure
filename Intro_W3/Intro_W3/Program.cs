using System;

namespace Intro_W3
{
    class Program
    {
        static void Main(string[] args)
        {
            Prime prime1 = new Prime();
            prime1.GetPrimeNumbers(150);
            for(int i =0; i < prime1.primes.Count; i++)
            {
                Console.WriteLine(prime1.primes[i]);            
            }
        }
    }
}


