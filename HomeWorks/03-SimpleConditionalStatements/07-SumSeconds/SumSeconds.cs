using System;

class SumSeconds
{
    static void Main(string[] args)
    {
        int s1 = int.Parse(Console.ReadLine());
        int s2 = int.Parse(Console.ReadLine());
        int s3 = int.Parse(Console.ReadLine());

        string output = $"{(s1 + s2 + s3) / 60}:{((s1 + s2 + s3) % 60):D2}";

        Console.WriteLine(output);
    }
}