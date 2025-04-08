using System;

class MatrixPrinter
{
    public void MatrixPrinterFunc()
    {
        Console.Write("Enter a positive integer N (N < 20): ");
        int N;

        if (int.TryParse(Console.ReadLine(), out N) && N > 0 && N < 20)
        {
            for (int row = 1; row <= N; row++)
            {
                for (int col = row; col < row + N; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 19.");
        }
    }
}