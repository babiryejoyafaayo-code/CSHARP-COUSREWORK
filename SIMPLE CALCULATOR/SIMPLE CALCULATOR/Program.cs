using System;
using System.Globalization;

namespace SavingsCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("=======================================");
            Console.WriteLine("        COMPOUND SAVINGS CALCULATOR    ");
            Console.WriteLine("=======================================");
            Console.WriteLine();

            double initialDeposit = GetValidDouble("Enter your initial deposit/starting balance UG SHS: ");
            double monthlyContribution = GetValidDouble("Enter your monthly contribution amount UG SHS: ");
            double annualRate = GetValidDouble("Enter the annual interest rate (%): ") / 100;
            int years = (int)GetValidDouble("Enter number of years: ");

            double balance = initialDeposit;
            double monthlyRate = annualRate / 12;
            double totalContributions = initialDeposit;

            Console.WriteLine();
            Console.WriteLine("Year    Balance (UG SHS)");
            Console.WriteLine("------------------------");

            for (int year = 1; year <= years; year++)
            {
                for (int month = 1; month <= 12; month++)
                {
                    balance += balance * monthlyRate;   // add monthly interest
                    balance += monthlyContribution;     // add monthly deposit
                    totalContributions += monthlyContribution;
                }

                Console.WriteLine($"{year,-8}{balance:N0}");
            }

            double interestEarned = balance - totalContributions;

            Console.WriteLine();
            Console.WriteLine($"Total you deposited: UG SHS {totalContributions:N0}");
            Console.WriteLine($"Interest earned:     UG SHS {interestEarned:N0}");
            Console.WriteLine($"Final balance:       UG SHS {balance:N0}");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static double GetValidDouble(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (double.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out double value) && value >= 0)
                {
                    return value;
                }

                Console.WriteLine("Invalid input. Please enter a positive number.");
            }
        }
    }
}