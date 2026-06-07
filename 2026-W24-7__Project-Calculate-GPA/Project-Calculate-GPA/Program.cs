// to get gpa: multiply grade value by credit Grade, do for each couse then sum them all, divide sum by total sum of credit Grade

string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course1Grade = 4;

int course2Credit = 3;
int course2Grade = 3;

int course3Credit = 4;
int course3Grade = 3;

int course4Credit = 4;
int course4Grade = 3;

int course5Credit = 3;
int course5Grade = 4;

decimal finalGpa = (course1Credit * course1Grade + course2Credit * course2Grade + course3Credit * course3Grade + course4Credit * course4Grade + course5Credit * course5Grade) / (decimal)(course1Credit + course2Credit + course3Credit + course4Credit + course5Credit);

Console.WriteLine($"Student:\t\t{studentName}\nCourse\t\t\tGrade\t\tCredit Hours");
Console.WriteLine($"{course1Name}\t\t{course1Grade}\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t{course2Grade}\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t{course3Grade}\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t{course4Grade}\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t{course5Grade}\t\t{course5Credit}");
Console.WriteLine($"Final GPA:\t\t{finalGpa:f2}");

// other way to calculate and format 2.d.p final gpa
int leadingDigit = (int)finalGpa;
int firstDigit = (int)(finalGpa * 10) % 10;
int secondDigit = (int)(finalGpa * 100) % 10;
Console.WriteLine("\n\nFancy way to write GPA: " + leadingDigit + "." + firstDigit + secondDigit);
