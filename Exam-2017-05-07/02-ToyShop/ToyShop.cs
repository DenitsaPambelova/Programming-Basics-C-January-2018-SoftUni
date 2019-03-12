using System;

class ToyShop
{
    static void Main(string[] args)
    {
        double tripPrice = double.Parse(Console.ReadLine());
        int puzzels = int.Parse(Console.ReadLine());
        int dolls = int.Parse(Console.ReadLine());
        int bears = int.Parse(Console.ReadLine());
        int minions = int.Parse(Console.ReadLine());
        int trucks = int.Parse(Console.ReadLine());

        int toys = puzzels + dolls + bears + minions + trucks;
        double sold = puzzels * 2.60 + dolls * 3 + bears * 4.10 + minions * 8.20 + trucks * 2;

        if (toys >= 50)
        {
            sold *= 0.75;
        }

        double moneyLeft = sold * 0.90;
        string output = $"Not enough money! {tripPrice - moneyLeft:F2} lv needed.";

        if (moneyLeft >= tripPrice)
        {
            output = $"Yes! {moneyLeft - tripPrice:F2} lv left.";
        }

        Console.WriteLine(output);
    }
}