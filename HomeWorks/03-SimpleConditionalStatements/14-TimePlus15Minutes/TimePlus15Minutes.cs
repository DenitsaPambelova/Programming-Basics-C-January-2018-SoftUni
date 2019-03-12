using System;

class TimePlus15Minutes
{
    static void Main(string[] args)
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());

        int minutesPlus15 = minutes + 15;

        if (minutesPlus15 > 59)
        {
            hours++;
            minutes = minutesPlus15 - 60;
        }
        else
        {
            minutes += 15;
        }
        if (hours == 24)
        {
            hours = 0;
        }

        Console.WriteLine($"{hours}:{minutes:D2}");
    }
}