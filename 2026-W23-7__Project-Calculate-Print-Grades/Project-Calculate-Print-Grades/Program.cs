// initialize variables - graded assignments
int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

// sums
int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

// write output
Console.WriteLine("Sophia: " + sophiaSum);
Console.WriteLine("Nicolas: " + nicolasSum);
Console.WriteLine("Zahirah: " + zahirahSum);
Console.WriteLine("Jeong: " + jeongSum + "\n\n");

// calc.
Console.WriteLine($"Student\t\tGrade");
Console.WriteLine($"Sophia:\t\t{(decimal)sophiaSum / currentAssignments} A");
Console.WriteLine($"Nicolas:\t{(decimal)nicolasSum / currentAssignments} B");
Console.WriteLine($"Zahirah:\t{(decimal)zahirahSum / currentAssignments} B");
// Very weird that the last one always doesn't get the tab why is that
// Console.WriteLine($"Jeong: \t {(decimal)jeongSum / currentAssignments} A");
// it seems it's because the Jeong doesn't have enough characters and needs to pad it???
// Like adding more as this is now makes it layout just fine that's super weird
// Console.WriteLine($"Jeonghhhh: \t {(decimal)zahirahSum / currentAssignments} A");
// it's because of 4-char intervals are stop locations so strings of five chars doesn't fill the gap?
Console.WriteLine($"Jeong:\t\t{(decimal)jeongSum / currentAssignments} A");
