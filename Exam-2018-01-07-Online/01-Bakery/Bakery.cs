using System;

class Bakery
{
    static void Main(string[] args)
    {
        int startDough = int.Parse(Console.ReadLine());
        int breadWeight = int.Parse(Console.ReadLine());
        double breadPrice = double.Parse(Console.ReadLine());
        int breadSold = int.Parse(Console.ReadLine());
        int cakeSold = int.Parse(Console.ReadLine());

        double breadIncome = breadSold * breadPrice;
        double breadCost = breadSold * breadWeight * 0.004;
        double cakeIncome = cakeSold * breadPrice * 1.25;
        double usedDough = breadSold * breadWeight + cakeSold * breadWeight * 0.8;
        double income = breadIncome + cakeIncome - breadCost - startDough * 0.004;

        Console.WriteLine($"Pure income: {income:F2} lv.");
        Console.WriteLine($"Dough used: {Math.Round(usedDough)} g.");
    }
}