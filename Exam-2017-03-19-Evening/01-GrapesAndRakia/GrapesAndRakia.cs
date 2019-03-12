using System;

class GrapesAndRakia
{
    static void Main(string[] args)
    {
        double area = double.Parse(Console.ReadLine());
        double kgPerMeter = double.Parse(Console.ReadLine());
        double trash = double.Parse(Console.ReadLine());

        double grapes = area * kgPerMeter - trash;
        double grapesMoney = grapes * 0.55 * 1.5;
        double rakiaMoney = grapes * 0.45 / 7.5 * 9.8;

        Console.WriteLine($"{rakiaMoney:F2}");
        Console.WriteLine($"{grapesMoney:F2}");
    }
}