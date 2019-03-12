using System;

class PoolPipes
{
    static void Main(string[] args)
    {
        int poolVolume = int.Parse(Console.ReadLine());
        int pipeOneDebit = int.Parse(Console.ReadLine());
        int pipeTwoDebit = int.Parse(Console.ReadLine());
        double hours = double.Parse(Console.ReadLine());

        double p1Liters = pipeOneDebit * hours;
        double p2Liters = pipeTwoDebit * hours;
        double filledLiters = p1Liters + p2Liters;
        double poolPercent = (filledLiters * 100) / poolVolume;
        double p1Percent = (p1Liters * 100) / filledLiters;
        double p2Percent = (p2Liters * 100) / filledLiters;
        string output = $"For {hours} hours the pool overflows with {(filledLiters - poolVolume):F1} liters.";

        if (poolVolume >= filledLiters)
        {
            output = $"The pool is {Math.Floor(poolPercent)}% full. Pipe 1: {Math.Floor(p1Percent)}%. Pipe 2: {Math.Floor(p2Percent)}%.";
        }

        Console.WriteLine(output);
    }
}