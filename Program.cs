using System;

public class Program {
    public static void Main(string[] args) {
        Console.Clear();

        Console.WriteLine("Enter a number");
        int number = int.Parse(Console.ReadLine() ?? "0");
        string result = "Undefined";

        switch (number) {
            case 0: result = "Zero"; break;
            case 1: result = "One"; break;
            case 2: result = "Two"; break;
            case 3: result = "Three"; break;
            case 4: result = "Four"; break;
            case 5: result = "Five"; break;
            case 6: result = "Six"; break;
            case 7: result = "Seven"; break;
            case 8: result = "Eight"; break;
            case 9: result = "Nine"; break;
            case 10: result ="Ten"; break;
            default: Console.WriteLine("That number is not in range."); System.Environment.Exit(0); break;
        }

        Console.WriteLine("Your number is " + result);

    }

}