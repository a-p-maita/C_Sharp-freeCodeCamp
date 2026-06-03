// Challenge is to output two lines `This is the first line.`, newline, then `This is the second line.`

// This gives error CS8802 only one compilation unit can have top-level statements, this is because it's seeing other projects and confuses them so you need to isolate it.
// Wrong - got error because generated a `Program.cs` with diff. code when running `dotnet new console` so just skip that one

// Correct code is
Console.Write("This is the first line.\n");
Console.Write("This is the second line.\n");

// Space
Console.WriteLine("");

// Also possible
Console.WriteLine("This is the first line");
Console.WriteLine("This is the second line");

// Space mk.2
Console.Write("\n");

// Odder but also a thing seems to be
Console.Write("This is");
Console.Write(" the");
Console.Write(" first line.\n");
Console.Write("This is the ");
Console.Write("second line");
Console.WriteLine(".");
