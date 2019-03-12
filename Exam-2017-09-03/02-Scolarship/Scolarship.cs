using System;

class Scolarship
{
    static void Main(string[] args)
    {
        double income = double.Parse(Console.ReadLine());
        double grades = double.Parse(Console.ReadLine());
        double salary = double.Parse(Console.ReadLine());

        double social = 0;
        double excellent = 0;

        if (grades >= 4.5 && income < salary)
        {
            social = salary * 0.35;
        }

        if (grades >= 5.5)
        {
            excellent = grades * 25;
        }

        string output = "You cannot get a scholarship!";

        if (excellent > social)
        {
            output = $"You get a scholarship for excellent results {Math.Floor(excellent)} BGN";
        }
        else if (social > excellent)
        {
            output = $"You get a Social scholarship {Math.Floor(social)} BGN";
        }

        Console.WriteLine(output);
    }
}