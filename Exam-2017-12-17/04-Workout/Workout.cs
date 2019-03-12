using System;

class Workout
{
    static void Main(string[] args)
    {
        int days = int.Parse(Console.ReadLine());
        double kilometers = double.Parse(Console.ReadLine());
        double total = kilometers;

        for (int i = 0; i < days; i++)
        {
            int percent = int.Parse(Console.ReadLine());
            kilometers += kilometers * percent / 100;
            total += kilometers;
        }

        if (total >= 1000)
        {
            Console.WriteLine($"You've done a great job running {Math.Ceiling((total - 1000))} more kilometers!");
        }
        else
        {
            Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(1000 - total)} more kilometers");
        }
    }
}