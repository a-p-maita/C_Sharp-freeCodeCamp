// Default code, operands are obvious here
int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
// How many times 7 goes into 1 (division)
// Works as div with integers, and as proper division with float, double, decimal etc.
int quotient = 7 / 5;
// remainder or modulus, outputs dividend
int remainder = 7 % 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);
Console.WriteLine("Remainder: " + remainder);

// Works as division
decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"Decimal Quotient: {decimalQuotient}");

// Also works
decimal decimalQuotient1 = 7 / 5.0m;
Console.WriteLine($"Decimal Quotient 1: {decimalQuotient1}");
decimal decimalQuotient2 = 7.0m / 5.0m;
Console.WriteLine($"Decimal Quotient 2: {decimalQuotient2}");

// These won't work or give inaccurate results though
// first three are bad data types, last
// int decimalQuotientA = 7 / 5.0m;
// int decimalQuotientB = 7.0m / 5;
// int decimalQuotientC = 7.0m / 5.0m;
// Doesn't work because there's no `m` suffix for either so they're treated as int I believe?
decimal decimalQuotientD = 7 / 5;
Console.WriteLine($"Decimal Quotient 3: {decimalQuotientD}");
