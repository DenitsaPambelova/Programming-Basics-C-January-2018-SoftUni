using System;

class Money
{
    static void Main(string[] args)
    {
        int bitcoins = int.Parse(Console.ReadLine());
        double yuans = double.Parse(Console.ReadLine());
        double comission = double.Parse(Console.ReadLine());

        double leva = bitcoins * 1168 + yuans * 0.15 * 1.76;
        double euro = leva / 1.95 * (100 - comission) / 100;

        Console.WriteLine($"{euro:F2}");
    }
}