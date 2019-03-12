using System;

class BackToThePast
{
    static void Main(string[] args)
    {
        double money = double.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());

        int age = 18;

        for (int currentYear = 1800; currentYear <= year; currentYear++)
        {
            if (currentYear % 2 == 0)
            {
                money -= 12000;
            }
            else
            {
                money -= 12000 + 50 * age;
            }
            age++;
        }

        if (money >= 0)
        {
            Console.WriteLine($"Yes! He will live a carefree life and will have {money:F2} dollars left.");
        }
        else
        {
            Console.WriteLine($"He will need {Math.Abs(money):F2} dollars to survive.");
        }
    }
}