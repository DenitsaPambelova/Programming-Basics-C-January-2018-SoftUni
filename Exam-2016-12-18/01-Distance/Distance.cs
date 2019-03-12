using System;

class Distance
{
    static void Main(string[] args)
    {
        const double minute = 60;
        int speed = int.Parse(Console.ReadLine());
        double time1 = int.Parse(Console.ReadLine()) / minute;
        double time2 = int.Parse(Console.ReadLine()) / minute;
        double time3 = int.Parse(Console.ReadLine()) / minute;

        double distance = time1 * speed + time2 * speed * 1.1 + time3 * speed * 1.1 * 0.95;

        Console.WriteLine($"{distance:F2}");
    }
}