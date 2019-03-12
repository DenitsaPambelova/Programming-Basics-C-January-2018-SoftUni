using System;

class FruitCocktails
{
    static void Main(string[] args)
    {
        string fruit = Console.ReadLine().ToLower();
        string size = Console.ReadLine().ToLower();
        int quantity = int.Parse(Console.ReadLine());
        double price = quantity;

        switch (fruit)
        {
            case "watermelon":
                if (size == "small")
                {
                    price *= 2 * 56;
                }
                else
                {
                    price *= 5 * 28.70;
                }

                break;
            case "mango":
                if (size == "small")
                {
                    price *= 2 * 36.66;
                }
                else
                {
                    price *= 5 * 19.60;
                }

                break;
            case "pineapple":
                if (size == "small")
                {
                    price *= 2 * 42.10;
                }
                else
                {
                    price *= 5 * 24.80;
                }

                break;
            case "raspberry":
                if (size == "small")
                {
                    price *= 2 * 20;
                }
                else
                {
                    price *= 5 * 15.20;
                }

                break;
        }

        if (price > 1000)
        {
            price *= 0.50;
        }
        else if (price >= 400)
        {
            price *= 0.85;
        }

        Console.WriteLine($"{price:F2} lv.");
    }
}