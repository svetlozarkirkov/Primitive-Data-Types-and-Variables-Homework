using System;
using System.Collections.Generic;
using System.Linq;

namespace NineDigitMagicNumbers
{
    class NineDigitMagicNumbers
    {
        static void Main()
        {
            int sum = int.Parse(Console.ReadLine());
            int diff = int.Parse(Console.ReadLine());
            List<string> collection = new List<string>();
            int count = 0;

            for (int i = 111; i <= 777; i++)
            {
                int b = i + diff;
                int c = b + diff;

                int[] firstPart = i.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();
                int[] secondPart = b.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();
                int[] thirdPart = c.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();

                if (firstPart[0] >= 1 && firstPart[0] <= 7 && firstPart[1] >= 1 && firstPart[1] <= 7 &&
                    firstPart[2] >= 1 && firstPart[2] <= 7 && secondPart[0] >= 1 && secondPart[0] <= 7 && secondPart[1] >= 1 && secondPart[1] <= 7 &&
                    secondPart[2] >= 1 && secondPart[2] <= 7 && thirdPart[0] >= 1 && thirdPart[0] <= 7 && 
                    thirdPart[1] >= 1 && thirdPart[1] <= 7 &&
                    thirdPart[2] >= 1 && thirdPart[2] <= 7 && 
                    firstPart.Sum()+secondPart.Sum()+thirdPart.Sum()==sum)
                {
                    count++;
                    string first = string.Join("", firstPart);
                    string second = string.Join("", secondPart);
                    string third = string.Join("", thirdPart);
                    string joined = first + second + third;
                    collection.Add(joined);
                }
            }
            if (count==0)
            {
                Console.WriteLine("No");
                return;
            }
            else
            {
                int insideCount = 0;
                foreach (var item in collection)
                {
                    if (item.Length==9)
                    {
                        Console.WriteLine(item);
                        insideCount++;
                    }
                }
                if (insideCount==0)
                {
                    Console.WriteLine("No");
                }
            }
        }
    }
}
