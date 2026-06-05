// How to do newlines manually without Console method
Console.Write("What's up\nGood people?\n\n\n");

// How to do characters usually reserved for string
Console.WriteLine("I could swear he said \"Don't even bother trying\"\n\n");

// The character "\" is also a reserved character for escape sequences so
Console.WriteLine("The windows path is c:\\user\\downloads\n\n");

// To format the output with escape char.
Console.WriteLine("Invoices for \"Generic Heartless Inc.\" ... \n");
Console.WriteLine("Invoice: 2026-03/2026-04\tTotal = £40,333,794");
Console.WriteLine("Invoice: 2026-04/2026-05\tTotal = £46,433,010\n\n");

// For verbatim string literal - one that keeps all whitespace and chars. without the need to escape the backslash - use @
Console.WriteLine(@"
```markdown
I would say that the repository lives in:
  - `c:\source\repo`
But that's just a theory, a code theory.
```
(Funky code block right there ^ \n\t\r)
" + "\n\n");

// For adding encoded characters in literal strings with `\u` then a four-char code
// It's for Unicode UTF-16 so no emojis I believe
/// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
// arabic teheh looks like a smiley, close enough
Console.WriteLine("\u067F\n\n");

// Format output with unicode escape chars for some reason, maybe you don't have access to \n or something but that would be weird
// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");
