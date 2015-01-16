using System;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main()
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            double precision = 0.000001;
            if (FindDifference(a,b) >= precision)
            {
                Console.WriteLine("Not Equal");
            }
            else
            {
                Console.WriteLine("Equal");
            }
            
        }
        static double FindDifference(double a, double b)
        {
            return Math.Abs(a-b);
        }
    }
}
