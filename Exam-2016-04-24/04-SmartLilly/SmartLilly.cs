using System;

class SmartLilly
{
    static void Main(string[] args)
    {
        int age = int.Parse(Console.ReadLine());
        double washerPrice = double.Parse(Console.ReadLine());
        double toyPrice = double.Parse(Console.ReadLine());

        double money = 0;
        int count = 0;

        for (int year = 1; year <= age; year++)
        {
            if (year % 2 != 0)
            {
                money += toyPrice;
            }
            else
            {
                count++;
                money += count * 10 - 1;
            }
        }

        if (money >= washerPrice)
        {
            Console.WriteLine($"Yes! {money - washerPrice:F2}");
        }
        else
        {
            Console.WriteLine($"No! {washerPrice - money:F2}");
        }
    }
}