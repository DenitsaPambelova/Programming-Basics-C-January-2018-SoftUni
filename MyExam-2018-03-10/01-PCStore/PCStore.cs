using System;

class PCStore
{
    static void Main(string[] args)
    {
        double processorPrice = double.Parse(Console.ReadLine());
        double videoCardPrice = double.Parse(Console.ReadLine());
        double ramPrice = double.Parse(Console.ReadLine());
        int ramQuantity = int.Parse(Console.ReadLine());
        double discountPercent = double.Parse(Console.ReadLine());

        double totalDollars = (processorPrice + videoCardPrice) * (1 - discountPercent) + ramPrice * ramQuantity;
        double totalLeva = totalDollars * 1.57;

        Console.WriteLine($"Money needed - {totalLeva:F2} leva.");
    }
}
