# csharp Literals Variables

**Links:** [freeCodeCamp](https://www.freecodecamp.org/learn/foundational-c-sharp-with-microsoft/write-your-first-code-using-c-sharp/store-and-retrieve-data-using-literal-and-variable-values-in-c-sharp) [Microsoft Learn](https://learn.microsoft.com/en-us/training/modules/csharp-literals-variables/)

## Introduction - Unit 1/9

Learning Objectives:

- Create literals for five basic data types
- Declare & init. variables
- Retrieve and set variable values
- Allow compiler to determine variable data type when initialising

- Sometimes data is hard-coded in app
- Hard-coded vals. are constants that are unchanged throughout execution.
- **Hard-coded === Literal === Constant**

- Will learn how to define data types
- And how to simplify code by leaving it up to compiler to do

## Exercise - Print literal values - Unit 2/9

### Use character literals

- Printing single alphanumeric char, you create a **char literal** by surrounding with `'`
- Seems you can't just create a folder and .cs file just from terminal by usual unix methods and then `dotnet run`
  - So you need to make a new type of project from a template, like a console template, with `dotnet new console` and can pass folder name with `-f Char_Literals`
  - Only needs one .cs file and `Program.cs` is auto-generated so can remove it
- Using double quotes on a writeline creates a string, the diff. here is single quotes which creates a charecter literal
- So `Console.WriteLine("Hello");` != `Console.WriteLine('Hello');`
  - And the latter also give an error of CS1012 Too many characters in charectar literal, since it can only be a length of one

### Using integer literals

- For displaying whole numeric number, use **int literal**
- Doesn't require other surrounding operators like `char` or `string`, so no single/double quotes

### Using floating-point literals

- A decimal number
- C# supports 3 types: `float`, `double` and `decimal` with diff. precisions each of
  - `float` ~6-9 digits
  - `double` ~15-17 digits
  - `decimal`28-29 digits
- Default is a `double` unless specified
- The suffix/postfix for each type are:
  - `float` = `f`, `F`
  - `double` = \[BLANK\], `d`, `D`
  - `decimal` = `m`, `M`

### Using boolean literals

- Case-sensitive
- For all literals data types are enforced to help programmers
- E.g., if you need to work with words "false" and "true" use `string` and `char` data types
- But if you need to work with logical concept of T/F use `bool`

## Declare variables

- Literals are hard-coded and don't change throughout program.
- May need variables ofc.
- Variables can be assigned, read and changed.
- A varibale name is a human-friendly label the compiler assigns to an address in memory.
- Can create one with syntax `string firstName;`
  - I reckon then you can also assign it as `string secondName = "Boyd"`, and I'm right
