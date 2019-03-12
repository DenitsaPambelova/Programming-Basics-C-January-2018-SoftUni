using System;

class Birthday
{
    static void Main(string[] args)
    {
        int lenght = int.Parse(Console.ReadLine());
        int width = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());
        double sand = double.Parse(Console.ReadLine());

        int volume = lenght * width * height;
        double capacity = volume * 0.001;
        double filledPart = sand * 0.01;

        double litters = capacity * (1 - filledPart);
        Console.WriteLine($"{litters:F3}");
    }
}