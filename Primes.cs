using System;
using System.Collections.Generic;
using System.Text;
/* 
 * Developed by Greig Fields 12/15/2021 to support ASE Course
 * Permission to freely destribute as long as this header is attached
 */
namespace ASE_Code_Examples
{
    public static class Primes
    {
        public static int[] generatePrimes(int maxValue)
        {
            if(maxValue >= 2) // the only valid case
            {
                // declarations
                int s = maxValue + 1; // size of array\
                bool[] f = new bool[s];
                int i;

                // initialize array to true.
                for(i=0;i<s;i++)
                    f[i] = true;

                // get rid of known non-primes
                f[0] = f[1] = false;
                // sieve
                int j;
                for(i=2;i< Math.Sqrt(s) +1; i++)
                {
                    if(f[i]) // if i is uncrossed, cross its muliples.
                    {
                        for (j = 2 * i; j < s; j += i)
                            f[j] = false; // multiple is not a prime
                    }
                }
                // how many primes are there?
                int count = 0;
                for(i=0;i<s;i++)
                {
                    if (f[i])
                        count++; // bump count.

                }
                int[] primes = new int[count];
                // move the primes into the result
                for(i=0,j=0;i<s;i++)
                {
                    if (f[i]) // if prime
                        primes[j++] = i;
                }
                return primes; // return the primes
            }
            else
            {
                // maxValue < 2
                return new int[0]; // return null array if bad input.
            }
        }
        public static int[] generatePrimesBaseRefactor(int maxValue)
        {
            if (maxValue < 2) // the only valid case  No need to have most of the code indexe in.... Readability
            {
                // maxValue < 2
                return new int[0]; // return null array if bad input
            }
            // declarations
            int count = maxValue +1; // Actual number of good primes 
            bool[] f = new bool[maxValue+1];

            // initialize array to true.
            for (int i = 0; i < maxValue + 1; i++)
                f[i] = true;

            // get rid of known non-primes
            f[0] = f[1] = false;
            count -= 2; // subtract them from the overall count;
            // sieve
            
            for (int i = 2; i < Math.Sqrt(maxValue + 1) + 1; i++)
            {
                if (f[i]) // if i is uncrossed, cross its muliples.
                {
                    for (int j = 2 * i; j < maxValue + 1; j += i)
                    {
                        if (f[j] != false)
                        {
                            f[j] = false; // multiple is not a prime
                            count--;  // subtract from overall count of good primes
                        }
                    }
                }
            }

            int[] primes = new int[count];
            // move the primes into the result
            for (int i = 0, j = 0; i < maxValue + 1; i++)
            {
                if (f[i]) // if prime
                    primes[j++] = i;
            }
            return primes; // return the primes
        
        }
        public static int[][] GetFactors(int number)
        {
            int[][] FactorArray = new int[0][];  // array to hold factors two integers [0] = prime [1] = exponent 
            int[] RawFactors = new int[0]; // array holding raw factors as found i.e. 3x3x2x5 = 90;
            if(number <=3) // the number must be a prime
            {
                FactorArray = new int[1][]; // copy the number into the factor array and return
                FactorArray[0] = new int[2];
                FactorArray[0][0] = number;
                FactorArray[0][1] = 1; // this means it's a prime;
                return FactorArray;
            }            
            int[] lPrimes = generatePrimesBaseRefactor(number);
            int numPrimes = lPrimes.Length;
            if(lPrimes[numPrimes-1] == number) // it's a prime itself so it's it's own factor
            {
                FactorArray = new int[1][];
                FactorArray[0] = new int[2];
                FactorArray[0][0] = number;
                FactorArray[0][1] = 1; // this means it's a prime;
                return FactorArray;
            }

            int endFactor = 0;
            for(int i=0;i< numPrimes;i++)  // Find the maximum prime for the target number
            {
                if(lPrimes[i]*2 >= number) 
                {
                    endFactor = i;
                    break;
                }
            }
            int numfactors = 0;
            int remaining = number;
            while (remaining > 1)
            { 
                for (int FactorIndex = 0; FactorIndex <= endFactor; FactorIndex++) // less than or equal because this is an 
                {                                                                  // iteration through a set of indexes not a count of an array
                    if (lPrimes[FactorIndex] > remaining) // if the current remainder is smaller than the indexed prime break out
                        break; // start though prime factors again...
                    if (remaining % lPrimes[FactorIndex] == 0) // no remainder then this prime is a factor
                    {
                        int num = remaining % lPrimes[FactorIndex]; // add the prime to the list of factors
                        Array.Resize(ref RawFactors, numfactors + 1);
                        RawFactors[numfactors] = lPrimes[FactorIndex]; // This is a factor for the target number
                        remaining = remaining / lPrimes[FactorIndex]; // pull out the impact of the factor i.e.
                                                                      // 12/2 = 6 (2) then 6/3 = 2 (3) then 2/2 = 1 (2) so 2x3x2 = 12
                        numfactors++; // increment the number of prime factors
                    }
                    if(remaining == 1)
                    {
                        break;
                    }
                }
            }
            

            // add powers to list of prime factors i.e. 2x3x2x5x2 becomes 2^3x3x5
            FactorArray = new int[RawFactors.Length][];
            for(int i=0;i<RawFactors.Length;i++) // just copy in raw factors as is all with a power of 1
            {
                FactorArray[i] = new int[2];
                FactorArray[i][0] = RawFactors[i]; // copy in prime factor
                FactorArray[i][1] = 1; // holding each right now no reduction
            }
            return FactorArray;
        }
        public static int[][] findUniqueFactors(int[][] Factors)
        {
            int[][] uniquefactors = { Factors[0] };
            int TotalPrimeFactor = Factors[0][0];
            for (int i = 1; i < Factors.Length; i++) // lets go through each of the factors the first entry is already added
            {

                bool found = false;
                for (int ii = 0; ii < uniquefactors.Length; ii++) // lets go through the unique array...
                {
                    if (uniquefactors[ii][0] == Factors[i][0]) // did i find this factor in the unique array already
                    {
                        uniquefactors[ii][1]++; // increment the number of times it's a factor to use as exponent
                        found = true;
                        break;
                    }
                }
                if (found == false) // if it wasn't found in the current unique array add it...
                {
                    Array.Resize(ref uniquefactors, uniquefactors.Length + 1);
                    uniquefactors[uniquefactors.Length - 1] = Factors[i];
                }
            }
            return (uniquefactors);
        }
    }
}
