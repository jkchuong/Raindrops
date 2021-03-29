# Raindrops
The objective of this project is to write and test a function that takes an input (n) and outputs a string based on the input's value.

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

**Approach 1 - Normal Method:** The normal method is the first method written that takes a simplistic approach. It first initialises an empty string, then checks whether the input is divisible by 3, 5, or 7. If the input value is 0 or the resulting string is empty, then it output the input value, else it outputs a non-empty string.

**Approach 2 - Condensed Method:** The condensed method is identical to the first method except that it uses a for loop and a dictionary instead of multiple if statements which allows for easier scalability.

**Approach 3 - Prime Factorization:** The prime factorization method first checks if the value is 0, and returns 0 if it is. If not, it runs through a for loop that obtains its unique prime factors  by using a HashSet. It then outputs a string depending on whether the set contains 3, 5, or 7. 
