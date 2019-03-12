using System;

class HousePianting
{
    static void Main(string[] args)
    {
        double houseHeight = double.Parse(Console.ReadLine());
        double houseLength = double.Parse(Console.ReadLine());
        double coverHeight = double.Parse(Console.ReadLine());

        double sides = 2 * houseHeight * houseHeight + 2 * houseHeight * houseLength - 1.2 * 2 - 2 * 1.5 * 1.5;
        double cover = 2 * houseHeight * houseLength + houseHeight * coverHeight;
        double green = sides / 3.4;
        double red = cover / 4.3;

        Console.WriteLine($"{green:F2}");
        Console.WriteLine($"{red:F2}");
    }
}