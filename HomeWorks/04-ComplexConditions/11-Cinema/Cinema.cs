using System;

class Cinema
{
    static void Main(string[] args)
    {
        string projection = Console.ReadLine().ToLower();
        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());

        double price = 0;

        switch (projection)
        {
            case "premiere":
                price = 12;
                break;
            case "normal":
                price = 7.50;
                break;
            case "discount":
                price = 5;
                break;
        }

        double income = rows * columns * price;

        Console.WriteLine($"{income:F2} leva");
    }
}