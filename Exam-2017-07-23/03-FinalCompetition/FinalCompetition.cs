using System;

class FinalCompetition
{
    static void Main(string[] args)
    {
        int dancers = int.Parse(Console.ReadLine());
        double points = double.Parse(Console.ReadLine());
        string season = Console.ReadLine();
        string location = Console.ReadLine();

        double sum = points * dancers;

        switch ($"{location} {season}")
        {
            case "Bulgaria summer":
                sum *= 0.95;
                break;
            case "Bulgaria winter":
                sum *= 0.92;
                break;
            case "Abroad summer":
                sum *= 1.5 * 0.9;
                break;
            case "Abroad winter":
                sum *= 1.5 * 0.85;
                break;
        }

        double charity = sum * 0.75;
        double moneyPerDancer = (sum - charity) / dancers;

        Console.WriteLine($"Charity - {charity:F2}");
        Console.WriteLine($"Money per dancer - {moneyPerDancer:F2}");
    }
}