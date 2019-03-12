using System;

class OnTimeForTheExam
{
    static void Main(string[] args)
    {
        int examHour = int.Parse(Console.ReadLine());
        int examMinute = int.Parse(Console.ReadLine());
        int arriveHour = int.Parse(Console.ReadLine());
        int arriveMinute = int.Parse(Console.ReadLine());

        int examTImeInMinutes = examHour * 60 + examMinute;
        int arriveTimeInMinutes = arriveHour * 60 + arriveMinute;
        int differenceInMinutes = Math.Abs(examTImeInMinutes - arriveTimeInMinutes);
        string difference = $"{differenceInMinutes} minutes";

        if (differenceInMinutes >= 60)
        {
            difference = $"{differenceInMinutes / 60}:{differenceInMinutes % 60:D2} hours";
        }

        if (differenceInMinutes == 0)
        {
            Console.WriteLine("On time");
        }
        else if (examTImeInMinutes > arriveTimeInMinutes && examTImeInMinutes - 30 <= arriveTimeInMinutes)
        {
            Console.WriteLine("On time");
            Console.WriteLine($"{difference} before the start");
        }
        else if (examTImeInMinutes - 30 > arriveTimeInMinutes)
        {
            Console.WriteLine("Early");
            Console.WriteLine($"{difference} before the start");
        }
        else
        {
            Console.WriteLine("Late");
            Console.WriteLine($"{difference} after the start");
        }
    }
}