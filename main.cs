using System;

class Program {
 public static void Main(string[] args) {
     string[] salespersonNames = { "Danielle", "Edward", "Francis"};
     string[] allowedInitials = { "D", "E", "F" };
     double[] totalSales = new double[3];
     Console.WriteLine("Hi User, please enter an initial.");

        while (true) {
            Console.Write("salesperson: ");
            string initial = Console.ReadLine().ToUpper();

            int index = Array.IndexOf(allowedInitials, initial);
            if (index != -1) {
                double saleAmount;

                Console.Write("sale: ");
                while (!double.TryParse(Console.ReadLine(), out saleAmount) || saleAmount <= 0) {
                    Console.WriteLine("Invalid input. Please try again.");
                    Console.Write($"sale: ");
                }
                 totalSales[index] += saleAmount;
            }
            else {
                Console.WriteLine("    intermediate output: Error, invalid salesperson selected, please try again");
            }

            Console.Write("Another sale? (Yes/No) ");
            string input = Console.ReadLine().ToUpper();
            if (input != "YES") {
                break;
            }
        }

        double grandTotal = totalSales[0] + totalSales[1] + totalSales[2];
        Console.WriteLine($"\nGrand Total: ${grandTotal:N0}");

        string topSalespersonInitial = GetTopSalesperson(allowedInitials, totalSales);
        string topSalespersonName = salespersonNames[Array.IndexOf(allowedInitials, topSalespersonInitial)];     
        Console.WriteLine($"Highest Sale: {topSalespersonInitial} ({topSalespersonName})");
        }
    
        static string GetTopSalesperson(string[] allowedInitials, double[] totalSales) {
        int maxIndex = 0;
        double maxSales = totalSales[0];
            for (int i = 1; i < totalSales.Length; i++) {
                if (totalSales[i] > maxSales) {
                    maxSales = totalSales[i];
                    maxIndex = i;
                }
            }
            return allowedInitials[maxIndex];
        }
    }