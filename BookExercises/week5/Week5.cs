namespace BookExercises.week5;

public class Week5
{
    public void ConditionalStatement()
    {
        Console.WriteLine("Enter two numbers.");
        Console.Write("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());
        int biggerNumber = Math.Max(firstNumber, Math.Max(secondNumber, thirdNumber));
        if (firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            biggerNumber = firstNumber;
        }

        else if (secondNumber > firstNumber && secondNumber > thirdNumber)
        {
            biggerNumber = secondNumber;
        }

        if (thirdNumber > firstNumber && thirdNumber > secondNumber)
        {
            biggerNumber = thirdNumber;
        }
        
        Console.WriteLine("The bigger number is: {0}", biggerNumber);
    }
    
    public void ConditionalStatement2()
    {
        int first = 1;
        int second = 3;
        int third = 5;
        
        if (first == second && second == third)
        {
            Console.WriteLine("These three numbers are equal.");
        }
        else
        {
            if (first > second && first > third)
            {
                Console.WriteLine("The first number is greater.");
            }
            else if (second > first && second > third)
            {
                Console.WriteLine("The second number is greater.");
            }
            else
            {
                Console.WriteLine("The third number is greater.");
            }
        }
    }
    public void ConditionalStatement3()
    {
        char ch = 'X';
        if (ch == 'A' || ch == 'a')
        {
            Console.WriteLine("Vowel [ei]");
        }
        else if (ch == 'E' || ch == 'e')
        {
            Console.WriteLine("Vowel [i:]");
        }
        else if (ch == 'I' || ch == 'i')
        {
            Console.WriteLine("Vowel [ai]");
        }
        else if (ch == 'O' || ch == 'o')
        {
            Console.WriteLine("Vowel [ou]");
        }
        else if (ch == 'U' || ch == 'u')
        {
            Console.WriteLine("Vowel [ju:]");
        }
        else
        {
            Console.WriteLine("Consonant");
        }
    }
}