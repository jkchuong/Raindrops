using System;
using System.Collections.Generic;

namespace Raindrops
{
    public static class RaindropsMethods
    {
        public static string NormalMethod(int n)
        {
            if (n == 0 || n % 3 != 0 && n % 5 != 0 && n % 7 != 0)
                return n.ToString();

            string result = String.Empty;

            if (n % 3 == 0)
                result += "Pling";

            if (n % 5 == 0)
                result += "Plang";

            if (n % 7 == 0)
                result += "Plong";

            return result;
        }

        public static string PrimeFactorizationMethod(int n)
        {
            if (n == 0)
                return n.ToString();

            int val = n;
            HashSet<int> primeFactors = new();
            string result = String.Empty;

            for (int i = 2; i <= Math.Abs(n); i++)
            {
                while (n % i == 0)
                {
                    primeFactors.Add(i);
                    n /= i;
                    if (n == 0)
                        break;
                }
            }

            if (primeFactors.Contains(3))
                result += "Pling";

            if (primeFactors.Contains(5))
                result += "Plang";

            if (primeFactors.Contains(7))
                result += "Plong";

            if (string.IsNullOrEmpty(result))
                return val.ToString();

            return result;
        }
    }
}


//# Tech Test

//## Raindrops

//Write a function that takes as its input a number (n) and converts it to a string, the contents of which depend on the numbers factors

//- if the number has a factor of 3, output 'Pling'
//- if the number has a factor of 5, output 'Plang'
//- if the number has a factor of 7, output 'Plong'
//- if the number does not have any of the above as a factor simply return the numbers digits

//## Examples

//- 28's factors are 1, 2, 4, 7, 14 and 28: this would be a simple 'Plong'
//- 30's factors are 1, 2, 3, 5, 6, 10, 15, 30: this would be a 'PlingPlang'
//- 34 has four factors: 1, 2, 17, and 34: this would be '34'

//This test can be completed in a language of your choice and should be made available on your Github account in a public repository that does not mention Deloitte. You should write tests to cover your expected range of inputs and outputs. Commit often and document well.

//You will be assessed on the quality of your code, functional correctness, and your approach to quality assurance and testing.
