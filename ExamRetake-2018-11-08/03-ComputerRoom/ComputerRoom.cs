using System;

class ComputerRoom
{
    static void Main(string[] args)
    {
        string month = Console.ReadLine();
        int hours = int.Parse(Console.ReadLine());
        int groupSize = int.Parse(Console.ReadLine());
        string dayTime = Console.ReadLine();
        double price = 0;

        switch (month)
        {
            case "march":
            case "april":
            case "may":
                price = dayTime == "day" ? 10.5 : 8.4;

                #region if else variant
                //if (dayTime == "day")
                //{
                //    price = 10.5;
                //}
                //else
                //{
                //    price = 8.4;
                //}
                #endregion
                break;
            case "june":
            case "july":
            case "august":
                price = dayTime == "day" ? 12.6 : 10.2;

                #region if else variant
                //if (dayTime == "day")
                //{
                //    price = 12.6;
                //}
                //else
                //{
                //    price = 10.2;
                //}
                #endregion
                break;
            default:
                break;
        }

        if (groupSize >= 4)
        {
            price *= 0.9;
        }

        if (hours >= 5)
        {
            price *= 0.5;
        }

        Console.WriteLine($"Price per person for one hour: {price:F2}");
        Console.WriteLine($"Total cost of the visit: {price * groupSize * hours:F2}");
    }
}