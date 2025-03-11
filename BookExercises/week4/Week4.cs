namespace BookExercises.week4;

using System;

class Week4
{
    public void CalculateSum()
    {
        Console.WriteLine("Enter three integers:");
        
        // Read and parse three integers
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());
        
        // Calculate sum
        int sum = num1 + num2 + num3;
        
        // Print result
        Console.WriteLine("The sum is: " + sum);
    }

    public void CircleCalculations()
    {
        Console.Write("Enter the radius of the circle: ");
        double r = double.Parse(Console.ReadLine());
        
        double perimeter = 2 * Math.PI * r;
        double area = Math.PI * r * r;
        
        Console.WriteLine($"Perimeter: {perimeter}");
        Console.WriteLine($"Area: {area}");
    }
    
    public void MaxNumber()
    {
        Console.WriteLine("Enter two numbers:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int max = Math.Max(a, b);
        Console.WriteLine("Max: " + max);
    }
    
    public void MinNumber()
    {
        Console.WriteLine("Enter two numbers:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int max = Math.Min(a, b);
        Console.WriteLine("Max: " + max);
    }
    
    public void MaxMinNumbers()
    {
        Console.WriteLine("Enter three numbers:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int max = Math.Max(a, Math.Max(b, c));
        int min = Math.Min(a, Math.Min(b, c));
        Console.WriteLine("Max: " + max);
        Console.WriteLine("Min: " + min);
    }
}