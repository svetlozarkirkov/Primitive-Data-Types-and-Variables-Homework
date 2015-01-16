using System;

namespace JoroTheFootballPlayer
{
    class JoroTheFootballPlayer
    {
        private const int weekends = 52;
        static void Main()
        {
            string yearType = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int weekendsInHometown = int.Parse(Console.ReadLine());
            int normalWeekends = weekends - weekendsInHometown;
            double holidaysPlay = holidays/2d;
            double tiredWeekends = normalWeekends/3d;
            double gamesPlayed = (normalWeekends - tiredWeekends) + weekendsInHometown + holidaysPlay;
            if (yearType=="t")
            {
                gamesPlayed += 3;
                Console.WriteLine((int)gamesPlayed);
            }
            else
            {
                Console.WriteLine((int)gamesPlayed);
            }
        }
    }
}
