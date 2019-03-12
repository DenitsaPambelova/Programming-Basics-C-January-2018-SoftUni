using System;

class FruitOrVegetable
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        string output = "unknown";

        switch (input)
        {
            case "banana":
            case "apple":
            case "kiwi":
            case "cherry":
            case "lemon":
            case "grapes":
                output = "fruit";
                break;
            case "tomato":
            case "cucumber":
            case "pepper":
            case "carrot":
                output = "vegetable";
                break;
        }

        Console.WriteLine(output);
    }
}