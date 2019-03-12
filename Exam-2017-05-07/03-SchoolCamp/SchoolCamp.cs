using System;

class SchoolCamp
{
    static void Main(string[] args)
    {
        string season = Console.ReadLine().ToLower();
        string group = Console.ReadLine().ToLower();
        int students = int.Parse(Console.ReadLine());
        int nights = int.Parse(Console.ReadLine());

        double nightPrice = 0;
        string sport = "";

        switch (season)
        {
            case "winter":
                nightPrice = 9.60;

                switch (group)
                {
                    case "boys":
                        sport = "Judo";
                        break;
                    case "girls":
                        sport = "Gymnastics";
                        break;
                    case "mixed":
                        nightPrice = 10;
                        sport = "Ski";
                        break;
                }

                break;
            case "spring":
                nightPrice = 7.20;

                switch (group)
                {
                    case "boys":
                        sport = "Tennis";
                        break;
                    case "girls":
                        sport = "Athletics";
                        break;
                    case "mixed":
                        nightPrice = 9.50;
                        sport = "Cycling";
                        break;
                }

                break;
            case "summer":
                nightPrice = 15;

                switch (group)
                {
                    case "boys":
                        sport = "Football";
                        break;
                    case "girls":
                        sport = "Volleyball";
                        break;
                    case "mixed":
                        nightPrice = 20;
                        sport = "Swimming";
                        break;
                }
                break;
        }

        double fullPrice = nightPrice * nights * students;

        if (students >= 50)
        {
            fullPrice *= 0.5;
        }
        else if (students >= 20)
        {
            fullPrice *= 0.85;
        }
        else if (students >= 10)
        {
            fullPrice *= 0.95;
        }

        Console.WriteLine($"{sport} {fullPrice:F2} lv.");
    }
}