using System;

namespace ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Before: a={0}, b={1}", a, b);
            SwapValues(ref a, ref b);
            Console.WriteLine("After: a={0}, b={1}", a, b);
        }

        public static void SwapValues(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
