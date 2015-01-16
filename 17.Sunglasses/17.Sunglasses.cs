using System;

namespace Sunglasses
{
    class Sunglasses
    {
        static void Main()
        {
            int frameHeight = int.Parse(Console.ReadLine());
            int frameWidth = frameHeight*2;
            for (int i = 0; i < frameHeight; i++)
            {
                if (i == 0 || i == frameHeight-1)
                {
                    Console.Write(new string('*', frameWidth));
                    Console.Write(new string(' ', frameHeight));
                    Console.Write(new string('*', frameWidth));
                    Console.WriteLine();
                }
                else if (i > 0 && i < frameHeight/2 || i > frameHeight/2 && i < frameHeight-1)
                {
                    Console.Write('*');
                    Console.Write(new string('/',frameWidth-2));
                    Console.Write('*');
                    Console.Write(new string(' ',frameHeight));
                    Console.Write('*');
                    Console.Write(new string('/', frameWidth - 2));
                    Console.Write('*');
                    Console.WriteLine();
                }
                else if (i == frameHeight/2)
                {
                    Console.Write('*');
                    Console.Write(new string('/', frameWidth - 2));
                    Console.Write('*');
                    Console.Write(new string('|', frameHeight));
                    Console.Write('*');
                    Console.Write(new string('/', frameWidth - 2));
                    Console.Write('*');
                    Console.WriteLine();
                }
            }
        }
    }
}
