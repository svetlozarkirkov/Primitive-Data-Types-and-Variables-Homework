using System;

namespace IsoscelesTriangle
{
    class IsoscelesTriangle
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            
            int size = 4;
            
            for (int i = 0, k = 1, m = size-2; i < size; i++)
            {
                if (i == 0)
                {
                    Console.Write(new string(' ', size-1));
                    Console.Write(new string('\u00A9', 1));
                    Console.WriteLine();
                }
                else if (i > 0 && i < size-1)
                {
                    Console.Write(new string(' ', m));
                    Console.Write(new string('\u00A9', 1));
                    Console.Write(new string(' ', k));
                    Console.Write(new string('\u00A9', 1));
                    Console.WriteLine();
                    k+=2;
                    m--;
                }
                else if (i == size-1)
                {
                    Console.Write(new string('\u00A9', 1));
                    Console.Write(' ');
                    Console.Write(new string('\u00A9', 1));
                    Console.Write(' '); 
                    Console.Write(new string('\u00A9', 1));
                    Console.Write(' ');
                    Console.Write(new string('\u00A9', 1));
                    Console.Write(' ');
                    Console.WriteLine();
                }
            }
        }
    }
}
