using System;


class Program
{
    // method to retrieve numRolls for DiceRoller class
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!\n");
        Console.Write("How many dice rolls would you like to simulate? ");

        int numRolls = int.Parse(Console.ReadLine());
        // Creates the object variable
        DiceRoller roller = new DiceRoller();

        // Creates array that stores rolled numbers received from RollDice method
        int[] results = roller.RollDice(numRolls);

        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls = " + numRolls + ".\n");

        // for loop for all possible dice rolls
        for (int iCount = 2; iCount <= 12; iCount++)
        {
            Console.Write(iCount + ": ");
            // Formula to calculate number of *s
            int percentage = (results[iCount] * 100) / numRolls;
            // Prints *s based on variable percentage
            Console.WriteLine(new String('*', percentage));
        }
        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}

