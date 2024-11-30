/*
 * Name: [Logan Brooks]
 * South Hills Username: [lbrooks81]
 */
//DO NOT USE LINQ!

using System;
using System.ComponentModel;
using System.Data;

namespace IT230_Arrays1
{
    public class Source
    {
        // The players array does not count towards your memory limit
        public static int[] players; // Do not initialize the array here
        public static int size;
        public static void InsertIntoArray(int number)
        {
            // Initialize Array
            if (size == 0)
            {
                players = Array.Empty<int>();
            }
            // Check if there is room in the array
            // If not, grow the array
            if (size + 1 >= players.Length)
            {
                Grow();
            }

            // Append the number passed in to the array
            players[players.Length - 1] = number;

            size++;
        }

        public static int SearchArray(int number)
        {
            for (int i = 0; i < players.Length; i++)
            {
                if (players[i] == number)
                {
                    return i;
                }
            }
            return -1;
        }

        public static void DeleteFromArray(int number)
        {
            // Search array for number
            int index = SearchArray(number);

            // Number was not found
            if (index == -1)
            {
                return;
            }

            // Delete number from array
            for(int i = index; i < players.Length - 1; i++)
            {
                players[i] = players[i + 1];
            }
            if (--size < players.Length / 4)
            {
                Shrink();
            }
            

            // TODO: Delete the number passed in from the array. If number
            //  does not exist in the array, do nothing.
            // Remember, array elements must be contiguous. "Resize"
            //  the array properly.
        }

        public static void Grow()
        {
            int[] tempArray = new int[players.Length == 0 ? 1 : players.Length + 1];

            for (int i = 0; i < players.Length; i++)
            {
                tempArray[i] = players[i];
            }
            
            players = tempArray;
        }

        public static void Shrink()
        {
            int[] tempArray = new int[players.Length - 1];
            
            for (int i = 0; i < tempArray.Length; i++)
            {
                tempArray[i] = players[i];
            }
            
            players = tempArray;
        }
    }
}