using System;

namespace StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main()
        {
            string one = "Hello";
            string two = "World";
            object concat = one + " " + two;
            string result = concat.ToString();
            Console.WriteLine(result);
        }
    }
}
