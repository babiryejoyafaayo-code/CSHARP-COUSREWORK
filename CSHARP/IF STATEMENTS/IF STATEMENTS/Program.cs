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


        if (principal <= 0)
        {
            Console.WriteLine("Warning: Principal amount should be greater than zero.");
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
