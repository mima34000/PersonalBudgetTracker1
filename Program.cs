using System;

namespace PersonalBudgetTracker1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            BudgetManager manager = new BudgetManager();

            
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n==== PERSONAL BUDGET TRACKER ====");
                Console.WriteLine("1. Add transaction");
                Console.WriteLine("2. Show all transactions");
                Console.WriteLine("3. Show balance");
                Console.WriteLine("4. Delete transaction");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        //  new transaction
                        Transaction t = new Transaction();

                        // ask user to enter transaction details
                        Console.Write("Description: ");
                        t.Description = Console.ReadLine();

                        Console.Write("Amount (negative for expense): ");
                        t.Amount = decimal.Parse(Console.ReadLine());

                        Console.Write("Category: ");
                        t.Category = Console.ReadLine();

                        Console.Write("Date (YYYY-MM-DD): ");
                        t.Date = Console.ReadLine();

                        manager.AddTransaction(t);
                        break;

                    case "2":
                        
                        manager.ShowAll();
                        break;

                    case "3":
                        // calculate total balance
                        decimal balance = manager.CalculateBalance();

                        // show balance in green if positive, red if negative
                        if (balance >= 0)
                            Console.ForegroundColor = ConsoleColor.Green;
                        else
                            Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine($"\nBalance: {balance}");
                        Console.ResetColor();
                        break;

                    case "4":
                        // show first so user knows which number to pick
                        manager.ShowAll();

                        Console.Write("Enter number to delete: ");
                        // -1 because list starts from 1 not 0

                        int index = int.Parse(Console.ReadLine()) - 1;

                        // remove selected transaction
                        manager.DeleteTransaction(index);
                        break;

                    case "5":
                        // stop the program
                        running = false;
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
