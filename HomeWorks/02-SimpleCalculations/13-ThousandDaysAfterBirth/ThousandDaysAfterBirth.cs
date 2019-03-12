using System;
using System.Globalization;

class ThousandDaysAfterBirth
{
    static void Main(string[] args)
    {
        string inputDate = Console.ReadLine();

        string format = "dd-MM-yyyy";
        DateTime birthDate = DateTime.ParseExact(inputDate, format, CultureInfo.InvariantCulture);
        string outputDate = birthDate.AddDays(999).ToString(format);

        Console.WriteLine(outputDate);
    }
}