using System;
using System.Collections.Generic;

// This class is responsible for managing all transactions
public class BudgetManager
{
    // List that stores all transactions
    private List<Transaction> transactions = new List<Transaction>();

    // This method adds a new transaction to the list
    public void AddTransaction(Transaction transaction)
    {
        transactions.Add(transaction);
    }

    // This method shows all transactions in the console
    public void ShowAll()
    {
        foreach (Transaction transaction in transactions)
        {
            transaction.ShowInfo();
        }
    }

    // This method calculates and returns the total balance
    public decimal CalculateBalance()
    {
        decimal balance = 0;

        foreach (Transaction transaction in transactions)
        {
            balance += transaction.Amount;
        }

        return balance;
    }

    // This method removes a transaction by index
    public void DeleteTransaction(int index)
    {
        if (index >= 0 && index < transactions.Count)
        {
            transactions.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("Invalid index.");
        }
    }
}

