int farenheit = 94;
// Only need 32 and 5 to be decimals as this now does calculation correctly for if farenheit is a float and the multiplication too
// complier takes care of overriding operator correctly
decimal celcius = (farenheit - 32m) * (5m / 9);
Console.WriteLine($"The temperature is {celcius} Celcius");
// this is "fixed-point" https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings
// it's not about float, other option that works is also g for general, d doesn't work
Console.WriteLine($"The temperature to 1.d.p. is {celcius:f1} Celcius");
// How many overall chars to have so it's 4, a bit wonkier than fixed-point
Console.WriteLine($"The temperature to 2.d.p. is {celcius:g4} Celcius");
