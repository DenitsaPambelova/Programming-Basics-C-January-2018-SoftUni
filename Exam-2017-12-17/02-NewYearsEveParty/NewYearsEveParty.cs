using System;

class NewYearsEveParty
{
    static void Main(string[] args)
    {
        int guests = int.Parse(Console.ReadLine());
        int budget = int.Parse(Console.ReadLine());

        if (budget < guests * 20)
        {
            Console.WriteLine($"They won't have enough money to pay the covert. They will need {guests * 20 - budget} lv more.");
        }
        else if (budget > guests * 20)
        {
            int leftmoney = budget - guests * 20;
            Console.WriteLine($"Yes! {Math.Round(leftmoney * 0.4)} lv are for fireworks and {Math.Round(leftmoney * 0.6)} lv are for donation.");
        }
        else
        {
            Console.WriteLine("");
        }
    }
}