using System;

class TrainingLab
{
    static void Main(string[] args)
    {
        double lenght = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());

        double rows = Math.Floor((width - 1) * 100 / 70);
        double columns = Math.Floor(lenght * 100 / 120);

        double chairs = rows * columns - 3;

        Console.WriteLine(chairs);
    }
}