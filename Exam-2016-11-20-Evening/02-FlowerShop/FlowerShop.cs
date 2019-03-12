using System;

class FlowerShop
{
    static void Main(string[] args)
    {
        int magnolias = int.Parse(Console.ReadLine());
        int zyumbuls = int.Parse(Console.ReadLine());
        int roses = int.Parse(Console.ReadLine());
        int cactuses = int.Parse(Console.ReadLine());
        double giftPrice = double.Parse(Console.ReadLine());

        double money = (magnolias * 3.25 + zyumbuls * 4 + roses * 3.5 + cactuses * 8) * 0.95;
        string output = $"She will have to borrow {Math.Ceiling(giftPrice - money)} leva.";

        if (money >= giftPrice)
        {
            output = $"She is left with {Math.Floor(money - giftPrice)} leva.";
        }

        Console.WriteLine(output);
    }
}