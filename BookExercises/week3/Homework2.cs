namespace BookExercises.week3;

using System;

class DigitReverser
{
    public void ReverseDigits()
    {
        Console.Write("Enter a four-digit number: ");
        string input = Console.ReadLine();

        if (input.Length == 4 && int.TryParse(input, out int number))
        {
            char a = input[0], b = input[1], c = input[2], d = input[3];
            
            int sum = (a - '0') + (b - '0') + (c - '0') + (d - '0');
            Console.WriteLine("Sum of digits: " + sum);
            
            Console.WriteLine("Reversed order: " + d + c + b + a);
            
            Console.WriteLine("Last digit first: " + d + a + b + c);
            
            Console.WriteLine("Swapped second and third: " + a + c + b + d);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a four-digit number.");
        }
    }
}
