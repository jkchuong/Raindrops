using System;
using System.Collections.Generic;

namespace Raindrops
{
    public static class RaindropsMethods
    {
        public static string NormalMethod(int n)
        {
            string result = String.Empty;

            if (n % 3 == 0)
                result += "Pling";

            if (n % 5 == 0)
                result += "Plang";

            if (n % 7 == 0)
                result += "Plong";

            if (n == 0 || String.IsNullOrEmpty(result))
                return n.ToString();

            return result;
        }

        public static string CondensedNormalMethod(int n)
        {
            string result = String.Empty;
            int[] factors = new int[] { 3, 5, 7 };
            string[] strings = new string[] { "Pling", "Plang", "Plong" };

            for(int i = 0; i < factors.Length; i++)
            {
                if (n % factors[i] == 0)
                    result += strings[i];
            }

            if (n == 0 || String.IsNullOrEmpty(result))
                return n.ToString();

            return result;
        }

        public static string PrimeFactorizationMethod(int n)
        {
            string result = String.Empty;

            // Store the input
            int val = n;

            // Initialise list of unique integers
            HashSet<int> primeFactors = new();

            // Loop through integers up to n
            for (int i = 2; i <= Math.Abs(n); i++)
            {
                // Keep diving by i to remove that prime factor and store it in the hash set
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

            if (n == 0 || string.IsNullOrEmpty(result))
                return val.ToString();

            return result;
        }
    }
}
