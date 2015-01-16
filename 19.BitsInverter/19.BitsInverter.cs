using System;
using System.Collections.Generic;
using System.Linq;

namespace BitsInverter
{
    class BitsInverter
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            string[] nums = new string[n];

            for (int i = 0; i < nums.Length; i++)
            {
                int temp = int.Parse(Console.ReadLine());
                nums[i] = Convert.ToString(temp, 2).PadLeft(8, '0');
            }

            string sequence = string.Join("", nums);
            string[] seqArray = sequence.Select(c => c.ToString()).ToArray();

            for (int i = 0, j = 1; i < seqArray.Length; i++)
            {
                if (i == 0)
                {
                    if (seqArray[i] == "0")
                    {
                        seqArray[i] = "1";
                    }
                    else
                    {
                        seqArray[i] = "0";
                    }
                }
                else if (i == j * step)
                {
                    if (seqArray[i] == "0")
                    {
                        seqArray[i] = "1";
                    }
                    else
                    {
                        seqArray[i] = "0";
                    }
                    j++;
                }
            }
            string final = string.Join("", seqArray);
            var finalNums = Split(final, 8);

            foreach (var item in finalNums)
            {
                Console.WriteLine(Convert.ToInt32(item, 2));
            }

        }
        static IEnumerable<string> Split(string str, int chunkSize)
        {
            return Enumerable.Range(0, str.Length / chunkSize)
                .Select(i => str.Substring(i * chunkSize, chunkSize));
        }

    }
}
