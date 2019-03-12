using System;

class TradeComissions
{
    static void Main(string[] args)
    {
        string town = Console.ReadLine().ToLower();
        double sales = double.Parse(Console.ReadLine());

        bool smallSales = sales >= 0 && sales <= 500;
        bool mediumSales = sales > 500 && sales <= 1000;
        bool bigSales = sales > 1000 && sales <= 10000;
        bool hugeSales = sales > 10000;
        double comission = 0;

        switch (town)
        {
            case "sofia":
                if (smallSales)
                {
                    comission = sales * 0.05;
                }
                else if (mediumSales)
                {
                    comission = sales * 0.07;
                }
                else if (bigSales)
                {
                    comission = sales * 0.08;
                }
                else if (hugeSales)
                {
                    comission = sales * 0.12;
                }
                break;
            case "varna":
                if (smallSales)
                {
                    comission = sales * 0.045;
                }
                else if (mediumSales)
                {
                    comission = sales * 0.075;
                }
                else if (bigSales)
                {
                    comission = sales * 0.10;
                }
                else if (hugeSales)
                {
                    comission = sales * 0.13;
                }
                break;
            case "plovdiv":
                if (smallSales)
                {
                    comission = sales * 0.055;
                }
                else if (mediumSales)
                {
                    comission = sales * 0.08;
                }
                else if (bigSales)
                {
                    comission = sales * 0.12;
                }
                else if (hugeSales)
                {
                    comission = sales * 0.145;
                }
                break;
        }

        if (comission != 0)
        {
            Console.WriteLine($"{comission:F2}");
        }
        else
        {
            Console.WriteLine("error");
        }
    }
}