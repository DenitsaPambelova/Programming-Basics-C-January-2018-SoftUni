using System;

class VegetableMarket
{
    static void Main(string[] args)
    {
        double vegetablePrice = double.Parse(Console.ReadLine());
        double fruitPrice = double.Parse(Console.ReadLine());
        int vegetables = int.Parse(Console.ReadLine());
        int fruits = int.Parse(Console.ReadLine());

        double income = (vegetablePrice * vegetables + fruitPrice * fruits) / 1.94;

        Console.WriteLine(income);
    }
}
