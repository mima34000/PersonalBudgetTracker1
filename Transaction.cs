using System;

// This class represents one transaction (income or expense)
public class Transaction
{
    // Description of the transaction, for example "Salary" or "Groceries"
    public string Description { get; set; }

    // Amount of money
    // Positive value = income
    // Negative value = expense
    public decimal Amount { get; set; }

    // Category of the transaction, for example "Food", "Transport", "Income"
    public string Category { get; set; }

    // Date of the transaction written as text (YYYY-MM-DD)
    // The assignment requires the date to be stored as a string
    public string Date { get; set; }

    // This method prints all information about the transaction to the console
    public void ShowInfo()
    {
        // If amount is positive, show in green (income)
        if (Amount >= 0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        // If amount is negative, show in red (expense)
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }

        Console.WriteLine($"{Date} | {Category} | {Description} | {Amount}");

        // Reset color back to default
        Console.ResetColor();
    }

}
