using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DiceRoller
{
    private Random rand = new Random();

    public int[] RollDice(int numRolls)
    {
        int[] rollCounts = new int[13]; // 2 to 12

        for (int iCount = 0; iCount < numRolls; iCount++)
        {
            int roll = rand.Next(1, 7) + rand.Next(1, 7);
            rollCounts[roll]++;
        }

        return rollCounts;
    }
}

