namespace BookExercises.week7;

using System;

class Homework5
{
    public void FindMaximalSequence()
    {
        Console.WriteLine("Enter array elements separated by spaces:");
        string input = Console.ReadLine();

        int[] array = input.Split(' ')
            .Select(int.Parse)
            .ToArray();

        int maxElement = array[0];
        int maxLength = 1;
        int currentElement = array[0];
        int currentLength = 1;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == currentElement)
            {
                currentLength++;
            }
            else
            {
                currentElement = array[i];
                currentLength = 1;
            }

            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                maxElement = currentElement;
            }
        }

        Console.Write("Maximal sequence: ");
        for (int i = 0; i < maxLength; i++)
        {
            Console.Write(maxElement + " ");
        }
    }
}