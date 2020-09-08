using System;
using System.Collections.Generic;

namespace XUnitIntroPractice
{
    public class Program //Update the Program class to be public, so the test framework can see it.
    {
        static void Main(string[] args)
        {
            HelloWorld();
        }

        public static void HelloWorld()
        {
            Console.WriteLine("Hello, world!");
        }
        //Write a method called IsYesOrNo that will accept a string and return true if the string is “YES”, “Y”, “NO”, or “N”, in any casing, trimmed. Otherwise it will return false.
        public static bool IsYesOrNo(string input)
        {
            if (input.ToUpper().Trim() == "YES" || input.ToUpper().Trim() == "Y" || input.ToUpper().Trim() == "NO" || input.ToUpper().Trim() == "N")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsYesOrNoException(string input)
        {
            if (input.ToUpper().Trim() == "YES" || input.ToUpper().Trim() == "Y" || input.ToUpper().Trim() == "NO" || input.ToUpper().Trim() == "N")
            {
                return true;
            }
            else
            {
                throw new FormatException();
            }
        }

        public static void OutOfRange()
        {
            int[] values1 = { 3, 6, 9, 12, 15, 18, 21 };
            int[] values2 = new int[6];
            
            
            values2[values1.Length - 1] = values1[values1.Length - 1];
        }

        public static void NullTest()
        {
            int[] values = null;
            for (int ctr = 0; ctr <= 9; ctr++)
                values[ctr] = ctr * 2;

            foreach (var value in values)
                Console.WriteLine(value);
        }

        public static void ZeroTest()
        {
            int number1 = 3;
            int number2 = 0;

           int sum = number1 / number2;

        }

    }
}
