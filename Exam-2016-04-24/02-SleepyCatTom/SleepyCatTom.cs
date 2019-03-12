using System;

class SleepyCatTom
{
    static void Main(string[] args)
    {
        int holidays = int.Parse(Console.ReadLine());

        int workingDays = 365 - holidays;
        int playMinutes = workingDays * 63 + holidays * 127;

        if (playMinutes > 30000)
        {
            Console.WriteLine("Tom will run away");
            Console.WriteLine($"{(playMinutes - 30000) / 60} hours and {(playMinutes - 30000) % 60} minutes more for play");
        }
        else
        {
            Console.WriteLine("Tom sleeps well");
            Console.WriteLine($"{(30000 - playMinutes) / 60} hours and {(30000 - playMinutes) % 60} minutes less for play");
        }
    }
}