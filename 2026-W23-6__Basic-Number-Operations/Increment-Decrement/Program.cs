// syntax for incrementing and decrementing
int value = 0;
Console.WriteLine(value);
// add 8 the long way
value = value + 8;
Console.WriteLine(value);
// add 5 short way
value += 5;
Console.WriteLine(value);
// increment by 1
value++;
Console.WriteLine(value);
// decrement by 1
value--;
Console.WriteLine(value);
// subtract 7
value -= 7;
Console.WriteLine(value + "\n\n");

// changes the value only BEFORE it fetches it, interesting so printing twice is needed to show actual value shown
Console.WriteLine(value);
Console.WriteLine(++value);
// intuition would say that this next one should print the value held, but actually it lags 1 behind sooooo
Console.WriteLine(value++);
Console.WriteLine(value);
Console.WriteLine(--value);
Console.WriteLine(value--);
Console.WriteLine(value);
