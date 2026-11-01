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

        decimal simpleinterest = principal * rate * duration;
        decimal finalBalance = principal + simpleinterest;

        Console.WriteLine($"\n---savings summary---");
        Console.WriteLine($"Principle:{principal:c}");
        Console.WriteLine($"interest rate:{rate * 100m}%");
        Console.WriteLine($"Duration:{duration}years");
        Console.WriteLine($"Simple interest:{simpleinterest:C}");
        Console.WriteLine($"Final Balance:{finalBalance:C}");


        Console.WriteLine("\n---Yearly Breakdown---");
        for (int i = 1; i <= duration; i++)
        {
            decimal yearlyInterest = principal * rate * i;
            Console.WriteLine($"Year {i}: Total accumulated interest is {yearlyInterest:C}");
        }

        Console.WriteLine("\npress any key to exit...");
        Console.ReadKey();
    }
}
