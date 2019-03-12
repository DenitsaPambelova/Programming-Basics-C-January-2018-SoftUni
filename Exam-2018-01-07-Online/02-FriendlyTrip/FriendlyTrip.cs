using System;

class FriendlyTrip
{
    static void Main(string[] args)
    {
        int distance = int.Parse(Console.ReadLine());
        int litters = int.Parse(Console.ReadLine());
        double fuelPrice = double.Parse(Console.ReadLine());
        int money = int.Parse(Console.ReadLine());

        double moneyNeeded = fuelPrice * litters * distance / 100;

        if (money >= moneyNeeded)
        {
            Console.WriteLine($"You can take a trip. {(money - moneyNeeded):F2} money left.");
        }
        else
        {
            Console.WriteLine($"Sorry, you cannot take a trip. Each will receive {1.0 * money / 5:F2} money.");
        }
    }
}