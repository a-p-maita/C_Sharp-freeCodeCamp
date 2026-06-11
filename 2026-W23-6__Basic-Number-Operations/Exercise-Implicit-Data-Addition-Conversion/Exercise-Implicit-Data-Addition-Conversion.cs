// Add two numeric vals.
/// Have to use addition operator `+`
/// reuse of same symbol as concat. e.g., is called "overloading the operator"
/// compiler auto-detects what to use based on data types and other context

// Isn't it cool you can do one-line assignments.
int firstNum = 11; int secondNum = 6; string nameOne = "Dale";

//This doesn't work though
// int thirdNum, fourthNum = 33, 57;
// int thirdNum, int fourthNum = 33, 57;
Console.WriteLine(firstNum + secondNum);

// Mix data types to force implicit type conversions
// If you use both string and int values it casts it into string
Console.WriteLine(nameOne + " sold " + secondNum + " widgets.");

// Very interesting case it deals with vars. it treats all chars. as strings
// Outputs 116 rather than 17
Console.WriteLine(nameOne + " sold " + firstNum + secondNum + " widgets.");
// But this shows compiler to do calc. (short for calculator) first
Console.WriteLine("Bob sold " + (firstNum + secondNum) + " widgets.");
// () becomes another overloaded operator. Follows BIDMAS aka PEMDAS better fo C# order of operations yaddayadda
