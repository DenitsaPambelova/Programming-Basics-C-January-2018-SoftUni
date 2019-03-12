using System;

class Cups
{
    static void Main(string[] args)
    {
        int cups = int.Parse(Console.ReadLine());
        int workers = int.Parse(Console.ReadLine());
        int days = int.Parse(Console.ReadLine());

        int cupsMade = workers * days * 8 / 5;
        string output = $"Losses: {(cups - cupsMade) * 4.2:F2}";

        if (cupsMade >= cups)
        {
            output = $"{(cupsMade - cups) * 4.2:F2} extra money";
        }

        Console.WriteLine(output);
    }
}