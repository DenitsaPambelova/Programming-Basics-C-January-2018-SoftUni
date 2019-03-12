using System;

class CharityCompany
{
    static void Main(string[] args)
    {
        int days = int.Parse(Console.ReadLine());
        int cooks = int.Parse(Console.ReadLine());
        int cakes = int.Parse(Console.ReadLine());
        int gofrets = int.Parse(Console.ReadLine());
        int pancakes = int.Parse(Console.ReadLine());
        long dayCoocks = days * cooks;
        long allCakes = dayCoocks * cakes;
        long allGofrets = dayCoocks * gofrets;
        long allpancakes = dayCoocks * pancakes;

        long cakesMoney = allCakes * 45;
        double gofretsMoney = allGofrets * 5.80;
        double pancakesMoney = allpancakes * 3.20;
        double allMoney = cakesMoney + gofretsMoney + pancakesMoney;
        double savedMoney = (allMoney / 8) * 7;

        Console.WriteLine($"{savedMoney:F2}");
    }
}