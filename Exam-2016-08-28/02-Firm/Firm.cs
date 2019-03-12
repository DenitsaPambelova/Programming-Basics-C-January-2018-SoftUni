using System;

class Firm
{
    static void Main(string[] args)
    {
        int hoursNeeded = int.Parse(Console.ReadLine());
        int days = int.Parse(Console.ReadLine());
        int workers = int.Parse(Console.ReadLine());

        double hoursWorked = Math.Floor(days * 0.9 * 8) + workers * 2 * days;
        string output = "";

        if (hoursWorked >= hoursNeeded)
        {
            output = $"Yes!{hoursWorked - hoursNeeded} hours left.";
        }
        else
        {
            output = $"Not enough time!{hoursNeeded - hoursWorked} hours needed.";
        }

        Console.WriteLine(output);
    }
}