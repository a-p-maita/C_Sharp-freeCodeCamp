# 2026-05-31T1332Z__NOTES__FreeCodeCamp-Foundational-C#.md

**Links:** [freeCodeCamp](https://www.freecodecamp.org/learn/foundational-c-sharp-with-microsoft/write-your-first-code-using-c-sharp/write-your-first-c-sharp-code) [Microsoft Learn](https://learn.microsoft.com/en-us/training/modules/csharp-write-first/)

## Microsoft Learn - Introduction - Unit 1 of 7

Allows building of:

- Business apps for capturing, analyzying and processing data.
- Dynamic web apps.
- 2D/3D games.
- Financial and scientific apps.
- Cloud-based apps.
- Mobile apps.

Module Learning Objectives:

- Write first C# code.
- Use two diff. techniques to print messages as output.
- Diagnose code errors.
- Identify diff. C# syntax elements like operators, classes and methods.

## System Setup

I'm currently on CachyOS which is Arch-based, using VSCode. Since most tutorials are for Windows I have to look into how to do this project more in-depth but it's cool and fun. Also allows me to actually know a bit more about the inner-workings of the langauge and how it's actually set up.

Have to look externally how to run and compile and run from terminal:
    - [Arch](https://wiki.archlinux.org/title/.NET) doesn't have the terminal capabilities by default so install packages `dotnet-host dotnet-runtime dotnet-sdk dotnet-targeting-pack aspnet-runtime aspnet-targeting-pack`
    - And for newer ones, bacause some VSCode extensions don't work otherwise,  use suffix `dotnet-host dotnet-runtime-9.0 dotnet-sdk-9.0 dotnet-targeting-pack-9.0 aspnet-runtime-9.0 aspnet-targeting-pack-9.0`
    - Also to make it work had to [add directory to PATH](https://www.geeksforgeeks.org/linux-unix/add-directory-to-path-in-linux/)
        - Using `export PATH="$PATH:/path/to/directory"` as `export PATH="$PATH:~/.dotnet"`
    - Can verify it's installed correctly with `dotnet --info`

For good practice of projects and running it you create a folder per project so I made `mkdir Hello-World/`.

Then create the project files and their associations with `dotnet new console` only when inside the same dir. This creates the files:

- `Hello-World/Hello-World.csproj` (file with project info) in format of `XML`:

```xml
<Project Sdk="Microsoft.NET.Sdk">
<PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net10.0</TargetFramework>
    <RootNamespace>Hello_World</RootNamespace>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
</PropertyGroup>
</Project>
```

- `Hello-World/Program.cs` (file with the code, same as one written)
- `Hello-World/obj/Debug/net10.0/Hello-World.csproj.nuget.dgspec.json` (ones below are a mix of XML, JSON and bin files that show dependencies and build/pathing info about the project)
- `obj/Debug/net10.0/Hello-World.csproj.nuget.g.props`
- `obj/Debug/net10.0/Hello-World.csproj.nuget.g.targets`
- `Properties/project.assets.json`
- `Properties/project.nuget.cache`

Then run the file with `dotnet run`. This compiles the code, runs it and creates the `bin/` directory with more info about the project and the compiled code.

Interesting things generated are the `bin/Hello-World.dll` which is the compiled code and `dll` stands for Dynamic Link Library. Also `bin/Hello-World.pdb` which is a small database file that contains [information for the debugger](https://stackoverflow.com/questions/3899573/what-is-a-pdb-file) to work with.

## Hello World - Exercise - Write your first code - Unit 2 of 7

Valid file extensions are `.cs` or `.csharp`

First C# code:

```csharp
Console.WriteLine("Hello World!");
```

The output as expected is just `Hello World!`.

C# is case sensitive so you can't use single quotes or double quotes interchangably so you have to wrap them around if you want that and it gets outputted with the single quotes as characters:

```csharp
Console.WriteLine("'Hello, World Single Quote Edition!'")
```

Outputs:
`'Hello, World Single Quote Edition!'`

`Console.WriteLine()` automatically inputs a `\n` newline character after the string whereas the `Console.Write()` doesn't which has diff. use-cases.

## Learning how it works - Unit 3 of 7

A phrase surrounded by double quotes is called a **Literal String** - meaning you literally outputted the characters "H", "e", "l",...

`Console` is the **class** which has it's own methods that live inside it. The `.` to access the method of the classs is actually called a **member access operator** which represents how to *navigate* from the class to the method.

The `()` used to invoke a method of a class etc. is called a **metod invocation operator**.

The `;` is the **end of statement operator**. A **statement** is a compolete instruction in C# and the end of statement operator indicates to the compiler that the command is finished.

## Complete the challenge - Unit 4 of 7

Write c# to display two messages, easy as pie.

You're not meant to do `dotnet new console` each time for a project as this initiates a `Program.cs` and this casuses the `CS8802: Only one compilation unit can have the top-level statements`.

## Review of solution

Talks about how multiple `Console.Write()` can be used one after the other with whitespaces in the string too instead of a full string sentence by itself.
Nifty interesting but yeah no need for full section.

## Module assessment - Unit 6 of 7

Questions and answers:

- What is the primary job of the compiler?
  - The compiler primarily locates spelling mistakes in your code.
  - The compiler primarily executes your code.
  - The compiler primarily converts your code into an executable format that the computer can understand. **(Correct)**

- Which of the following statements is true about C#?
  - C# is case insensitive.
  - Console is a method, and WriteLine() is a class.
  - You use double quotation marks to create a literal string. **(Correct)**

- What is wrong with this line of code? `Console.WriteLine("What is wrong with me?")`
  - The L in WriteLine should be lower-case.
  - It's missing a semi-colon at the end. **(Correct)**
  - The string should use single-quotes.

## Unit 7 of 7

Completed, here's the [Achievement link](https://learn.microsoft.com/api/achievements/share/en-us/AndreasMaita-1526/K956434B?sharingId=9D348175C84F9240)
