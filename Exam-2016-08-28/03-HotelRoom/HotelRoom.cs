using System;

class HotelRoom
{
    static void Main(string[] args)
    {
        string month = Console.ReadLine().ToLower();
        int nights = int.Parse(Console.ReadLine());

        var studioPrice = 0.0;
        var apartmentPrice = 0.0;

        switch (month)
        {
            case "may":
            case "october":
                studioPrice = 50;
                apartmentPrice = 65;

                if (nights > 14)
                {
                    studioPrice *= 0.70;
                    apartmentPrice *= 0.90;
                }
                else if (nights > 7)
                {
                    studioPrice = 50 * 0.95;
                }

                break;
            case "june":
            case "september":
                studioPrice = 75.20;
                apartmentPrice = 68.70;

                if (nights > 14)
                {
                    studioPrice *= 0.80;
                    apartmentPrice *= 0.90;
                }

                break;
            case "july":
            case "august":
                studioPrice = 76;
                apartmentPrice = 77;

                if (nights > 14)
                {
                    apartmentPrice *= 0.90;
                }

                break;
        }

        Console.WriteLine($"Apartment: {nights * apartmentPrice:F2} lv.");
        Console.WriteLine($"Studio: {nights * studioPrice:F2} lv.");
    }
}