using System;

class Bills
{
    static void Main(string[] args)
    {
        int months = int.Parse(Console.ReadLine());

        double electricity = 0;
        double water = 0;
        double internet = 0;
        double others = 0;

        for (int i = 0; i < months; i++)
        {
            double electricityPerMonth = double.Parse(Console.ReadLine());

            double othersPerMonth = (electricityPerMonth + 35) * 1.2;

            electricity += electricityPerMonth;
            water += 20;
            internet += 15;
            others += othersPerMonth;
        }

        double allBills = electricity + water + internet + others;
        double average = allBills / months;

        Console.WriteLine($"Electricity: {electricity:F2} lv");
        Console.WriteLine($"Water: {water:F2} lv");
        Console.WriteLine($"Internet: {internet:F2} lv");
        Console.WriteLine($"Other: {others:F2} lv");
        Console.WriteLine($"Average: {average:F2} lv");
    }
}