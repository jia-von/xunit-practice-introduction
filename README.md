# C# XUnit Practice within Microsoft.NETCore.App

The goal of this assignment is designed to help me familiarized with the fundementals of XUnit testing.
 

## Installation

Packages used within this assignment includes:
- Microsoft.NET.Test.Sdk
- xunit

```bash
$ cd xunit-practice-oop-jia-von
$ cd XUnitTestProject1
$ start devenv XUnitTestProject1.sln
`````


## Approach

 - A solution and console application was created with a name `XUnitIntroPractice.sln`.
 - A second XUnit Test project was created with solution name `XUnitTestProject1.sln`.
 - A program was written to test method called `IsYesOrNo()`. This method will accept a string and return  true if the string is `“YES”`, `“Y”`, `“NO”`, or `“N”`, in any casing, trimmed. Otherwise it will return false.
   - XUnit tests were written that will test the trimming of whitespace (both spaces and tabs) before and after the text.
   - XUnit tests were written that will test the conversion to uppercase.
   - XUnit tests were written for all accepted values.
   - XUnit tests were written for invalid values. Include at least one single character invalid value, one multiple character one, and an empty string.
- Wrote assertions using `Throws<FormatException>`, `Throws<IndexOutOfRangeException>`, `Throws<NullReferenceException>`, and `Throws<DivideByZero Exception>`, to demonstrate my understanding thereof.

![Example Screenshot of XUnit testing](/Screenshot/XUnitTesting_ScreenShot.PNG)


