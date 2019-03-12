using System;

class MetricConverter
{
    static void Main(string[] args)
    {
        double amount = double.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        string output = Console.ReadLine();

        switch (input)
        {
            case "mm":
                amount /= 1000;
                break;
            case "cm":
                amount /= 100;
                break;
            case "mi":
                amount /= 0.000621371192;
                break;
            case "in":
                amount /= 39.3700787;
                break;
            case "km":
                amount /= 0.001;
                break;
            case "ft":
                amount /= 3.2808399;
                break;
            case "yd":
                amount /= 1.0936133;
                break;
        }

        switch (output)
        {
            case "mm":
                amount *= 1000;
                break;
            case "cm":
                amount *= 100;
                break;
            case "mi":
                amount *= 0.000621371192;
                break;
            case "in":
                amount *= 39.3700787;
                break;
            case "km":
                amount *= 0.001;
                break;
            case "ft":
                amount *= 3.2808399;
                break;
            case "yd":
                amount *= 1.0936133;
                break;
        }

        Console.WriteLine($"{amount:F8}");
    }
}