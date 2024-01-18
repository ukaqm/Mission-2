using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!\n");
        Console.Write("How many dice rolls would you like to simulate? ");

        int numRolls = int.Parse(Console.ReadLine());
        DiceRoller roller = new DiceRoller();

        int[] results = roller.RollDice(numRolls);

        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls = " + numRolls + ".\n");

        for (int iCount = 2; iCount <= 12; iCount++)
        {
            Console.Write(iCount + ": ");
            int percentage = (results[iCount] * 100) / numRolls;
            Console.WriteLine(new String('*', percentage));
        }
    }
}

