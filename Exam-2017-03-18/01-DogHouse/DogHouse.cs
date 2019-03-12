using System;

class DogHouse
{
    static void Main(string[] args)
    {
        double sideLength = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double sides = sideLength * sideLength;
        double back = sideLength / 2 * sideLength / 2 + sideLength / 2 * (height - sideLength / 2) / 2;
        double front = back - sideLength / 5 * sideLength / 5;
        double cover = sideLength * sideLength;
        double green = (sides + back + front) / 3;
        double red = cover / 5;

        Console.WriteLine($"{green:F2}");
        Console.WriteLine($"{red:F2}");
    }
}