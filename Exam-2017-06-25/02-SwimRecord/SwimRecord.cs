using System;

class SwimRecord
{
    static void Main(string[] args)
    {
        double record = double.Parse(Console.ReadLine());
        double distance = double.Parse(Console.ReadLine());
        double speed = double.Parse(Console.ReadLine());

        double slowings = Math.Floor(distance / 15);
        double time = distance * speed + slowings * 12.5;
        string output = $"No, he failed! He was {time - record:F2} seconds slower.";

        if (record > time)
        {
            output = $"Yes, he succeeded! The new world record is {time:F2} seconds.";
        }

        Console.WriteLine(output);
    }
}