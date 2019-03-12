using System;

class Choreography
{
    static void Main(string[] args)
    {
        int steps = int.Parse(Console.ReadLine());
        int dancers = int.Parse(Console.ReadLine());
        int days = int.Parse(Console.ReadLine());

        double percent = 100.0 * steps / days / steps;
        double percentD = Math.Ceiling(percent) / dancers;
        string output = $"No, They will not succeed in that goal! Required {percentD:F2}% steps to be learned per day.";

        if (percent <= 13)
        {
            output = $"Yes, they will succeed in that goal! {percentD:F2}%.");
        }

        Console.WriteLine(output);
    }
}