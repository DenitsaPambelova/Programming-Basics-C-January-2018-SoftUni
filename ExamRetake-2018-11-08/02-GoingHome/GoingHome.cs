using System;

class GoingHome
{
    static void Main(string[] args)
    {
        int distance = int.Parse(Console.ReadLine());
        int fuelConsuption = int.Parse(Console.ReadLine());
        decimal fuelPrice = decimal.Parse(Console.ReadLine());
        decimal money = int.Parse(Console.ReadLine());

        decimal moneyNeeded = fuelPrice * fuelConsuption * distance / 100;

        if (money >= moneyNeeded)
        {
            Console.WriteLine($"You can go home. {money - moneyNeeded:F2} money left.");
        }
        else
        {
            Console.WriteLine($"Sorry, you cannot go home. Each will receive {money / 5:F2} money.");
        }
    }
}