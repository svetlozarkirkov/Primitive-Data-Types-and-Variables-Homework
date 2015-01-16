using System;
using System.Collections.Generic;
using System.Linq;

namespace HalfSum
{
    class HalfSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> partOne = new List<int>();
            List<int> partTwo = new List<int>();
            for (int i = 0; i < n; i++)
            {
                partOne.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < n; i++)
            {
                partTwo.Add(int.Parse(Console.ReadLine()));
            }
            
            if (partOne.Sum() == partTwo.Sum())
            {
                Console.WriteLine("Yes, sum={0}",partOne.Sum());
            }
            else
            {
                Console.WriteLine("No, diff={0}",
                    Math.Max(partOne.Sum(),partTwo.Sum())-Math.Min(partOne.Sum(), partTwo.Sum()));
            }
        }
    }
}
