# Raindrops
The objective of this project is to write and test a function that takes an input (n) and outputs a string based on the input's value.

### User Guide

1. Clone the repository in your desired directory.
2. Open the test explorer to run the tests in Visual Studio or run ```dotnet test``` in the console.

### Rules

The rules are:

- if the input has a factor of 3, output "Pling",
- if the input has a factor of 5, output "Plang",
- if the input has a factor of 7, output "Plong",
- if the input does not have any of the above values as a factor, then return the input as a string.

Examples:

- 28 will output  "Plong".
- 30 will output "PlingPlang". 
- 34 will output "34".

### Testing

Automated tests will be written for each method created. Tests will cover all possible cases:

- Input of 0 or 1,
- Input of positive/negative integer that is divisible by 3,
- Input of positive/negative integer that is divisible by 5,
- Input of positive/negative integer that is divisible by 7,
- Input of positive/negative integer that is divisible by 3 and 5,
- Input of positive/negative integer that is divisible by 3 and 7,
- Input of positive/negative integer that is divisible by 5 and 7,
- Input of positive/negative integer that is divisible by 3, 5, and 7,
- Input of positive/negative integer that is not divisible by 3, 5, and 7.

  ### Approach

**Approach 1 - Normal Method:** 
```C#
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
```
The normal method takes a simplistic approach. It first initialises an empty string, then checks whether the input is divisible by 3, 5, or 7. If the input value is 0 or the resulting string is empty, then it output the input value, else it outputs a non-empty string.

**Approach 2 - Condensed Method:**
```C#
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
```
The condensed method is identical to the first method except that it uses a for loop and a dictionary instead of multiple if statements which allows for easier scalability.

**Approach 3 - Prime Factorization:**
```C#
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
```
The prime factorization method first checks if the value is 0, and returns 0 if it is. If not, it runs through a for loop that obtains its unique prime factors  by using a HashSet. It then outputs a string depending on whether the set contains 3, 5, or 7. 
