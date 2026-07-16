// Methods that don't return values are called void methods
// Can call method without storing value but just printing it etc.
// parameter/argument are interchangable but param refers to the var being used in the method, arg is the val that's passed when the method is called
// Method signature is used to define num and data types of params the method will accept
// Overloaded method signatures enables calling the method with/without args specified in the calling statement (running the method)
using System.Runtime.ExceptionServices;

int number = 7;
string text = "seven";

// The overloads are to accept diff data types and cast them as strings
Console.WriteLine(number);
Console.WriteLine();
Console.WriteLine(text);

// Use overloaded versions of Random.Next()
Random dice = new Random();
// Default range is 0 - 2,147,483,647
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"\n\nFirst roll: {roll1}\nSecond roll: {roll2}\nThird roll: {roll3}");
