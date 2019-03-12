using System;

class DailyProfit
{
    static void Main(string[] args)
    {
        int workDays = int.Parse(Console.ReadLine());
        double dayPay = double.Parse(Console.ReadLine());
        double exchange = double.Parse(Console.ReadLine());

        double yearMoney = workDays * dayPay * 14.5 * 0.75;
        double leva = yearMoney * exchange / 365;

        Console.WriteLine($"{leva:F2}");
    }
}