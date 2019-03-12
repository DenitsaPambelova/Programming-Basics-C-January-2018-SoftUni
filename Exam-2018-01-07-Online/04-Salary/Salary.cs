using System;

class Salary
{
    static void Main(string[] args)
    {
        double baseSalary = double.Parse(Console.ReadLine());
        int years = int.Parse(Console.ReadLine());
        string member = Console.ReadLine();

        double currentSalary = baseSalary;
        int moreYears = 0;

        for (int year = 1; year <= years; year++)
        {
            currentSalary *= 1.06;

            if (year % 10 == 0)
            {
                currentSalary += 200;
            }
            else if (year % 5 == 0)
            {
                currentSalary += 100;
            }
            else
            {
                if (member == "Yes")
                {
                    currentSalary *= 0.99;
                }
            }
        }

        if (currentSalary > 5000)
        {
            currentSalary = 5000;
            Console.WriteLine($"Current salary: {currentSalary:F2}");
        }
        else
        {
            Console.WriteLine($"Current salary: {currentSalary:F2}");

            for (int year = years + 1; year >= 0; year++)
            {
                currentSalary *= 1.06;

                if (year % 10 == 0)
                {
                    currentSalary += 200;
                }
                else if (year % 5 == 0)
                {
                    currentSalary += 100;
                }
                else
                {
                    if (member == "Yes")
                    {
                        currentSalary *= 0.99;
                    }
                }

                if (currentSalary < 5000)
                {
                    moreYears++;
                }
                else
                {
                    break;
                }
            }
        }

        Console.WriteLine($"{moreYears} more years to max salary.");
    }
}