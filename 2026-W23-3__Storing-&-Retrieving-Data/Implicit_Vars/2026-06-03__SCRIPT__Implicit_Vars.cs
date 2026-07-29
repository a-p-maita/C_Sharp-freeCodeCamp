// Unit 5/9

// Implicitly typed local variables can be used, compiler auto asssigns data type based on init value
var message = "Goodbye world?";
var number = 01.4323413m;
var msg2 = "Let a thousand blossoms bloom, but I ain't spending any time on it...";

// Can't just cast by tring to re-assign, probably special method for this
// Can't use `var` without giving a value otherwise no data type is used

Console.WriteLine(message, number);
Console.WriteLine(number);
Console.WriteLine(msg2, message);
// Seems only first arg is printed even if same data type
