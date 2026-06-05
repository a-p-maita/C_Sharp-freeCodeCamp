// Interpolation is where you have to combine many literal strings
// and variables into one single formatted message

string batallionNumber = "Charlie";
string escapeVehicle = "choppa";
string emergencyCommunication = "Team " + batallionNumber + " get to the " + escapeVehicle;

// Can be more concise with interpolation rather than concat
string emergencyCommunicationShort = $"Team {batallionNumber} get to the {escapeVehicle}";


// Both output the same thing
Console.WriteLine(emergencyCommunication);
Console.WriteLine(emergencyCommunicationShort);


// Also  useful for multiple data types
float linuxKernelVersion = 3.21f;
double numUpdates = 8;
string updateMessage = $"You have {numUpdates} updates pending to upgrade to kernel version {linuxKernelVersion}";
Console.WriteLine($"\n\n[CRITICAL] System Warning:\t{updateMessage}\n\n");


// Can combine interpolation and verbatim literals
// Ignore reuse of var. it's just convenient rather than a new float you get it
Console.WriteLine($@"C:\Programs\FreeCAD {linuxKernelVersion}\Data");
Console.WriteLine(@$"C:\Programs\FreeCAD {linuxKernelVersion}\Data");
