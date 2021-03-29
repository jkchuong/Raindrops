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

            Dictionary<int, string> kvp = new Dictionary<int, string>()
            {
                {3, "Pling" },
                {5, "Plang" },
                {7, "Plong" }
            };

            foreach (var item in kvp)
            {
                if (n % item.Key == 0)
                    result += item.Value;
            }

            if (n == 0 || String.IsNullOrEmpty(result))
                return n.ToString();

            return result;
        }

        public static string PrimeFactorizationMethod(int n)
        {
            string result = String.Empty;

            Dictionary<int, string> kvp = new Dictionary<int, string>()
            {
                {3, "Pling" },
                {5, "Plang" },
                {7, "Plong" }
            };

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

            foreach (var item in kvp)
            {
                if (primeFactors.Contains(item.Key))
                    result += item.Value;
            }

            if (n == 0 || string.IsNullOrEmpty(result))
                return val.ToString();

            return result;
        }
    }
}
