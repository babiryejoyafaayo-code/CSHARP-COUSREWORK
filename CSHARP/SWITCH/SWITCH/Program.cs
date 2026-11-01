
using System;

class SavingsCalculator
{
    static void Main()
    {
        decimal principal = 0m;
        decimal rate = 0.50m;
        decimal duration = 3m;

        Console.Write("Enter principal amount: ");
        principal = Convert.ToDecimal(Console.ReadLine());



        Console.Write("Enter account level (1 for Standard, 2 for Silver, 3 for Gold): ");
        int tier = Convert.ToInt32(Console.ReadLine());

        switch (tier)
        {
            case 1:
                rate = 0.30m;
                break;
            case 2:
                rate = 0.50m;


                break;
            case 3:
                rate = 0.70m;
                break;
            default:
                rate = 0.50m;
                break;
        }

        decimal simpleinterest = principal * rate * duration;
        decimal finalBalance = principal + simpleinterest;

        Console.WriteLine($"\n---savings summary---");
        Console.WriteLine($"Principle:{principal:c}");
        Console.WriteLine($"interest rate:{rate * 100m}%");
        Console.WriteLine($"Duration:{duration}years");
        Console.WriteLine($"Simple interest:{simpleinterest:C}");
        Console.WriteLine($"Final Balance:{finalBalance:C}");
        Console.WriteLine("\npress any key to exit...");
        Console.ReadKey();
    }
}