using System;

class Airplane
{
    static void Main(string[] args)
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        int time = int.Parse(Console.ReadLine());

        minutes += time;
        hours += minutes / 60;
        minutes %= 60;

        if (hours > 23)
        {
            hours -= 24;
        }

        Console.WriteLine($"{hours}h {minutes}m");
    }
}