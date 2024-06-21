using System;

class Program {
 public static void Main(string[] args) {
     Console.WriteLine("Hi User, please enter an initial.");
        double totalDanielle = 0;
        double totalEdward = 0;
        double totalFrancis = 0;

        while (true) {
            Console.Write("salesperson: ");
            string initial = Console.ReadLine().ToUpper();

            if (initial == "D" || initial == "E" || initial == "F") {
                double saleAmount;

                Console.Write("sale: ");
                while (!double.TryParse(Console.ReadLine(), out saleAmount) || saleAmount <= 0) {
                    Console.WriteLine("Invalid input. Please try again.");
                    Console.Write($"sale: ");
                }

                switch (initial) {
                    case "D":
                        totalDanielle += saleAmount;
                        break;
                    case "E":
                        totalEdward += saleAmount;
                        break;
                    case "F":
                        totalFrancis += saleAmount;
                        break;
                }
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

        double grandTotal = totalDanielle + totalEdward + totalFrancis;
        Console.WriteLine($"\nGrand Total: ${grandTotal:N0}");

        string topSalesperson = GetTopSalesperson(totalDanielle, totalEdward, totalFrancis);
        Console.WriteLine($"Highest Sale: {topSalesperson}");

        }

        static string GetTopSalesperson(double danielle, double edward, double francis) {
        if (danielle > edward && danielle > francis) {
            return "D";
        }
        else if (edward > danielle && edward > francis) {
            return "E";
        }
        else if (francis > danielle && francis > edward) {
            return "F";
        }
        else {
            return "No person found"; 
        }
     }
}