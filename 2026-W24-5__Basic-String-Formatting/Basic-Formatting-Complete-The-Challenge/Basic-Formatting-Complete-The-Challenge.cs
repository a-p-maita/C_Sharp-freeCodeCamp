// Challenge
// Print instructions to the end user to let them know where app will output data files

string projectName = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine(
$@"View English output:
  c:\Exercise\{projectName}\data.txt"
+ "\n"
);
Console.WriteLine(
$@"{russianMessage}:
  c:\Exercise\{projectName}\ru-RU\data.txt"
+ "\n"
);


// Cleaner solution
// I disagree that this matches up the tab/spaces as the actual challenge shows but WHATEVER
string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
Console.WriteLine($"View English output:\n\t{englishLocation}\n");
string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
Console.WriteLine($"{russianMessage}:\n\t{russianLocation}\n");
