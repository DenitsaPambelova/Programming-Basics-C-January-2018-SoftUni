using System;

class BonusScore
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        double bonus = 0.00;

        if (number % 2 == 0)
        {
            bonus++;
        }
        else if (number % 5 == 0)
        {
            bonus += 2;
        }

        if (number <= 100)
        {
            bonus += 5;
        }
        else if (number <= 1000)
        {
            bonus += number * 0.2;
        }
        else
        {
            bonus += number * 0.1;
        }

        Console.WriteLine(bonus);
        Console.WriteLine(number + bonus);
    }
}