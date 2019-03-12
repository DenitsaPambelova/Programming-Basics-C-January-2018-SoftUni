using System;

class Sandbox
{
    static void Main(string[] args)
    {
        double width = double.Parse(Console.ReadLine());
        double lenght = double.Parse(Console.ReadLine());
        double sandPrice = double.Parse(Console.ReadLine());
        double boardPrice = double.Parse(Console.ReadLine());

        double sandArea = (width - 0.4) * (lenght - 0.4);
        double boardArea = width * lenght - sandArea;
        double sandNeeded = Math.Ceiling(sandArea * 20);
        double boardsNeeded = Math.Ceiling(boardArea / 0.44);
        double totalPrice = sandNeeded * sandPrice + boardsNeeded * boardPrice;

        Console.WriteLine($"{totalPrice:F2}");
    }
}