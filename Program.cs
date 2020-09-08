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
    }
}
