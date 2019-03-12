using System;

class TrainersSalary
{
    static void Main(string[] args)
    {
        int lessons = int.Parse(Console.ReadLine());
        double budget = double.Parse(Console.ReadLine());

        double jelev = 0;
        double royal = 0;
        double roli = 0;
        double trofon = 0;
        double sino = 0;
        double others = 0;
        double lectionSalary = budget / lessons;

        for (int i = 0; i < lessons; i++)
        {
            string lector = Console.ReadLine().ToLower();

            switch (lector)
            {
                case "jelev":
                    jelev += lectionSalary;
                    break;
                case "royal":
                    royal += lectionSalary;
                    break;
                case "roli":
                    roli += lectionSalary;
                    break;
                case "trofon":
                    trofon += lectionSalary;
                    break;
                case "sino":
                    sino += lectionSalary;
                    break;
                default:
                    others += lectionSalary;
                    break;
            }
        }

        Console.WriteLine($"Jelev salary: {jelev:F2} lv");
        Console.WriteLine($"RoYaL salary: {royal:F2} lv");
        Console.WriteLine($"Roli salary: {roli:F2} lv");
        Console.WriteLine($"Trofon salary: {trofon:F2} lv");
        Console.WriteLine($"Sino salary: {sino:F2} lv");
        Console.WriteLine($"Others salary: {others:F2} lv");
    }
}