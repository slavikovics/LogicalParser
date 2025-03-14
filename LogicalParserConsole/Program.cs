﻿using LogicalParser;

namespace LogicalParserConsole;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter logical formula");
            string? formula = Console.ReadLine();
            if (formula is null) return;

            Table table = new Table(formula);
            Console.WriteLine(table.Content);
        }
        
        Console.ReadKey();
    }
}