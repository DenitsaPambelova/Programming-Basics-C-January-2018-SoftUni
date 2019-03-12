using System;

class Voleyball
{
    static void Main(string[] args)
    {
        string yearType = Console.ReadLine().ToLower();
        int holidays = int.Parse(Console.ReadLine());
        int weekendsHome = int.Parse(Console.ReadLine());

        double sofiaWeekends = 48 - weekendsHome;
        double sofiaGames = sofiaWeekends * 3 / 4;
        double holidayGames = holidays * 2.0 / 3;
        double allGames = sofiaGames + holidayGames + weekendsHome;

        if (yearType == "leap")
        {
            allGames *= 1.15;
        }

        Console.WriteLine(Math.Floor(allGames));
    }
}