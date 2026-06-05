// This is all quite basic but here

string bookLineOne;
string bookLineOnePointFive;
string bookLineTwo = "But then she woke up and realised... it was all a dream";
string bookLineThree = @"Isn't it crazy that this could have all just ended with a \n";

// This is valid assigning within a WriteLine method that's neat
Console.WriteLine("\n\n" + (bookLineOne = "Once upon a time there was something or someone or whatever in the world") + "\n" + bookLineTwo + "\n" + bookLineThree + "\n" + bookLineOne + "\n\n");

// Interesting that this is valid and if I don't do the last bookLineOnePointFive it still is but there's a warning
// That it's assigned but never used
Console.WriteLine((bookLineOnePointFive = "Once upon a time there WASN'T something or someone or whatever in the world") + "\n" + bookLineTwo + "\n" + bookLineThree);
