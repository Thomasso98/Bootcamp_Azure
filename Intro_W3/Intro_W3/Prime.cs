using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_W3
{
    class Prime
    {
        //Variables
        // accessmodifier type name (= value);
        private bool nonprime;
        public List<int> primes;

        // constructor
        public Prime()
        {
            primes = new List<int>();
        }

        // methods
        // accessmodifier returntype name(){}

        public void GetPrimeNumbers(int maxrange)
        {
            for(int i = 2; i < (maxrange+1); i++)
            {
                for(int y= 2; y< i; y++)
                {
                    if(i % y == 0)
                    {
                        nonprime = true;
                        break; 
                    }
                }
                if (!nonprime)
                {
                    primes.Add(i);
                }
                nonprime = false;
            }
        }
    }
}