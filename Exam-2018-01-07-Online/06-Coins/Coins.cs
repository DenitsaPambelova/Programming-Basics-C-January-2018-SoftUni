using System;

class Coins
{
    static void Main(string[] args)
    {
        double change = double.Parse(Console.ReadLine());
        int coins = 0;

        int changeInCoins = Convert.ToInt32(change * 100);

        if (changeInCoins / 200 > 0)
        {
            coins += changeInCoins / 200;
            changeInCoins %= 200;
        }

        if (changeInCoins / 100 > 0)
        {
            coins += changeInCoins / 100;
            changeInCoins %= 100;
        }

        if (changeInCoins / 50 > 0)
        {
            coins += changeInCoins / 50;
            changeInCoins %= 50;
        }

        if (changeInCoins / 20 > 0)
        {
            coins += changeInCoins / 20;
            changeInCoins %= 20;
        }

        if (changeInCoins / 10 > 0)
        {
            coins += changeInCoins / 10;
            changeInCoins %= 10;
        }

        if (changeInCoins / 5 > 0)
        {
            coins += changeInCoins / 5;
            changeInCoins %= 5;
        }

        if (changeInCoins / 2 > 0)
        {
            coins += changeInCoins / 2;
            changeInCoins %= 2;
        }

        coins += changeInCoins;
        Console.WriteLine(coins);
    }
}