using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DiceRoller
{
    // Use random class create an object to generate random numbers
    private Random rand = new Random();
    public int[] RollDice(int numRolls)
    {
        // Creates an array to store the number of times a number was rolled
        // Only indices 2-12 are used
        int[] rollCounts = new int[13]; 

        // For loop the keeps a counter for each number rolled and stores it in the roll counts array
        for (int iCount = 0; iCount < numRolls; iCount++)
        {
            // Generates two random number 1-6 to simulate two dice and adds them together
            int roll = rand.Next(1, 7) + rand.Next(1, 7);
            // Adds to the counter for whatever number was rolled 
            rollCounts[roll]++;
        }

        return rollCounts;
    }
}

