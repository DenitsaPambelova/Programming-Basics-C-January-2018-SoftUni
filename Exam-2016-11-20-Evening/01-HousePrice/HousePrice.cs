using System;

class HousePrice
{
    static void Main(string[] args)
    {
        double smallestRoom = double.Parse(Console.ReadLine());
        double kitchen = double.Parse(Console.ReadLine());
        double price = double.Parse(Console.ReadLine());

        double bathroom = smallestRoom * 0.5;
        double secondRoom = smallestRoom * 1.1;
        double thirdRoom = secondRoom * 1.1;
        double area = (smallestRoom + secondRoom + thirdRoom + bathroom + kitchen) * 1.05;
        double fullPrice = area * price;

        Console.WriteLine($"{fullPrice:F2}");
    }
}