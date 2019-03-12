using System;

class SmallShop
{
    static void Main(string[] args)
    {
        string product = Console.ReadLine();
        string town = Console.ReadLine();
        double quantity = double.Parse(Console.ReadLine());

        double price = 0;
        string input = $"{town} {product}";

        switch (input)
        {
                    case "Sofia coffee":
                        price = 0.50;
                        break;
                    case "Plovdiv coffee":
                        price = 0.40;
                        break;
                    case "Varna coffee":
                        price = 0.45;
                        break;
                    case "Sofia water":
                        price = 0.80;
                        break;
                    case "Plovdiv water":
                    case "Varna water":
                        price = 0.70;
                        break;
                    case "Sofia beer":
                        price = 1.20;
                        break;
                    case "Plovdiv beer":
                        price = 1.15;
                        break;
                    case "Varna beer":
                        price = 1.10;
                        break;
                    case "Sofia sweets":
                        price = 1.45;
                        break;
                    case "Plovdiv sweets":
                        price = 1.30;
                        break;
                    case "Varna sweets":
                        price = 1.35;
                        break;
                    case "Sofia peanuts":
                        price = 1.60;
                        break;
                    case "Plovdiv peanuts":
                        price = 1.50;
                        break;
                    case "Varna peanuts":
                        price = 1.55;
                        break;
        }

        Console.WriteLine(quantity * price);
    }
}