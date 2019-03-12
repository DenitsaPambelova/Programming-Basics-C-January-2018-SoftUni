using System;

class NumberZeroTo100ToText
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        int tens = number / 10;
        int ones = number % 10;
        string tensText = "";
        string onesText = "";
        string numberToText = "";

        switch (ones)
        {
            case 0:
                onesText = "";
                break;
            case 1:
                onesText = "one";
                break;
            case 2:
                onesText = "two";
                break;
            case 3:
                onesText = "three";
                break;
            case 4:
                onesText = "four";
                break;
            case 5:
                onesText = "five";
                break;
            case 6:
                onesText = "six";
                break;
            case 7:
                onesText = "seven";
                break;
            case 8:
                onesText = "eight";
                break;
            case 9:
                onesText = "nine";
                break;
        }

        if (number < 0 || number > 100)
        {
            numberToText = "invalid number";
        }
        else if (tens > 1)
        {
            switch (tens)
            {
                case 2:
                    tensText = "twenty ";
                    break;
                case 3:
                    tensText = "thirty ";
                    break;
                case 4:
                    tensText = "forty ";
                    break;
                case 5:
                    tensText = "fifty ";
                    break;
                case 6:
                    tensText = "sixty ";
                    break;
                case 7:
                    tensText = "seventy ";
                    break;
                case 8:
                    tensText = "eighty ";
                    break;
                case 9:
                    tensText = "ninety ";
                    break;
                case 10:
                    numberToText = "one hundred";
                    break;
            }
        }
        else if (tens == 1 && ones > 2)
        {
            switch (ones)
            {
                case 3:
                    tensText = "thir";
                    break;
                case 4:
                    tensText = "four";
                    break;
                case 5:
                    tensText = "fif";
                    break;
                case 6:
                    tensText = "six";
                    break;
                case 7:
                    tensText = "seven";
                    break;
                case 8:
                    tensText = "eight";
                    break;
                case 9:
                    tensText = "nine";
                    break;
            }
            onesText = "teen";
        }
        else
        {
            switch (number)
            {
                case 0:
                    numberToText = "zero";
                    break;
                case 10:
                    numberToText = "ten";
                    break;
                case 11:
                    numberToText = "eleven";
                    break;
                case 12:
                    numberToText = "twelve";
                    break;
            }
        }

        if (numberToText == "")
        {
            numberToText = tensText + onesText;
        }

        Console.WriteLine(numberToText);
    }
}