// Unit 2/9



// Char literals
// Has len limit of 1
// So `Console.WriteLine('hello');` is incorrect and gives CS1012
Console.WriteLine('b');



// Int literals
Console.WriteLine(123454321);



// Floating-point literals

// This creates a float
Console.WriteLine(2.14159F);
Console.WriteLine(7.14159f);
// Was trying to see if there's in-built constants like pi but maybe it's a diff import or syntax
// Console.WriteLine(pi);
// Experimenting with getting type for the hell of it, nothing concrete and it'll prob. tell me how later
// Console.WriteLine((2.3452F).GetType());

// This creates a double
// Happens when there's no explicit suffix/postfix
// Looks like it can also be explicit and case insensitive
Console.WriteLine(3.555555555);
Console.WriteLine(2.555555555D);
Console.WriteLine(1.555555555d);

// This creates a decimal literal, append suffix of `m` or `M`
Console.WriteLine(14.387243948234892M);
Console.WriteLine(15.83716589m);



// Boolean literals
// Interesting thing is that output is capitalised but the input isn't
Console.WriteLine(true);
Console.WriteLine(false);
// Just makes doubles not very python-like of you microsoft tisk tisk
Console.WriteLine(1);
Console.WriteLine(0);
// Case-sensitive so these below don't work
// Console.WriteLine(True);
// Console.WriteLine(False);
