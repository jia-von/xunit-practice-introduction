using System;
using Xunit; //Add an assembly reference from the XUnit project to the console application.
using XUnitIntroPractice;

namespace XUnitIntroPractice_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void HelloWorld_Test()
        {
            Program.HelloWorld();
        }

        /*
         Write XUnit tests that will test the trimming of whitespace (both spaces and tabs) before and after the text.
            9 test case permutations. “YES”, “Y”, “NO”, or “N”
         */

        //static bool IsYesOrNo(string input)
        [Theory,
            InlineData("YES ", true), //Right trail space
            InlineData(" YES", true), //Left trail space
            InlineData("YES    ", true), // tab right
            InlineData("    YES", true),//tab left
            InlineData("Y E S", false), //Trim() doesn't remove white space in between characters, it only remove trailing whitespace
            InlineData("Y   E   S", false),
            InlineData(" YES ", true),//Trail space left and right
            InlineData("    YES    ", true),//Tab space left and right
            InlineData("    What    ", false)
            ]
        public void Program_IsYesOrNo_Trim(string test, bool expectedResult)
        {
            Assert.Equal(Program.IsYesOrNo(test), expectedResult);
        }

        /*
         Write XUnit tests that will test the conversion to uppercase.
            3 test case permutations.
         */
        [Theory,
            InlineData("yes", true),
            InlineData("YES", true),
            InlineData("yEs", true)
            ]
        public void Program_IsYesOrNo_ToUpper(string test, bool expectedResult)
        {
            Assert.Equal(Program.IsYesOrNo(test), expectedResult);
        }

        /*
         Write XUnit tests for all accepted values.
            4 test case permutations.
         */


        [Theory,
            InlineData("YES", true),
            InlineData("NO", true),
            InlineData("Y", true),
            InlineData("N", true)
            ]
        public void Program_IsYesOrNo_Values(string test, bool expectedResult)
        {
            Assert.Equal(Program.IsYesOrNo(test), expectedResult);
        }

        /*
         Write XUnit tests for invalid values. Include at least one single character invalid value, one multiple character one, and an empty string.
         */

        [Theory,
            InlineData("A", false),
            InlineData("Okay", false),
            InlineData("", false)
            ]
        public void Program_IsYesOrNo_InvalidValues(string test, bool expectedResult)
        {
            Assert.Equal(Program.IsYesOrNo(test), expectedResult);
        }

        /*
         * Write assertions using Throws<FormatException>, Throws<IndexOutOfRangeException>, Throws<NullReferenceException> and Throws<DivideByZero Exception>, to demonstrate your understanding thereof. You can use built in C# methods.
         */

        [Theory,
        InlineData("A"),
        InlineData("Okay"),
        InlineData("")
                    ]
        public void Program_IsYesOrNo_ThrowFormatException(string test)
        {
            Assert.Throws<FormatException>(() => Program.IsYesOrNoException(test)); //Exception in this example can be replaced with a specific type of exception, and it will test for that and only that exception
        }

        [Fact]
        public void ThrowFormatOutOfRange()
        {
            Assert.Throws<IndexOutOfRangeException>(() => Program.OutOfRange()); //Exception in this example can be replaced with a specific type of exception, and it will test for that and only that exception
        }

        [Fact]
        public void NullTest()
        {
            Assert.Throws<NullReferenceException>(() => Program.NullTest()); //Exception in this example can be replaced with a specific type of exception, and it will test for that and only that exception
        }

        [Fact]
        public void DivideByZeroTest()
        {
            Assert.Throws<DivideByZeroException>(() => Program.ZeroTest()); //Exception in this example can be replaced with a specific type of exception, and it will test for that and only that exception
        }

    }
}
