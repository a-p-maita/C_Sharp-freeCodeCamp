Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine($"Dice rolled {roll}");
int dndRoll = dice.Next(1, 21);
Console.WriteLine($"DnD D20 dice rolled {dndRoll}");
// Stateless aka. static methods are ones that don't require current state of app to work
// Meaning it works without referencing or changing values in memory

// Stateful aka. instance methods are the opposite and do require referencing/changing values in memory
// They keep track of their state in fields which are variables defined on the class
