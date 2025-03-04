using BookExercises.week3;

class Week3
{
    public void Week3Learnings()
            {
            int squarePerimeter = 17;
            double squareSide = squarePerimeter / 4.0;
            double squareArea = squareSide * squareSide;
            Console.WriteLine(squareSide); // 4.25
            Console.WriteLine(squareArea); // 18.0625

            int a = 5;
            int b = 4;
            Console.WriteLine(a + b); // 9
            Console.WriteLine(a + (b++)); // 9
            Console.WriteLine(a + b); // 10
            Console.WriteLine(a + (++b)); // 11
            Console.WriteLine(a + b); // 11
            Console.WriteLine(14 / a); // 2
            Console.WriteLine(14 % a); // 4

            int one = 1;
            int zero = 0;
            // Console.WriteLine(one / zero); // DivideByZeroException

            double dMinusOne = -1.0;
            double dZero = 0.0;
            Console.WriteLine(dMinusOne / zero); // -Infinity
            Console.WriteLine(one / dZero); // Infinity
            Console.WriteLine((a + 3) * (b -1));
            
            
            bool bA = true;
            bool bB = false;
            Console.WriteLine(bA && bB); // False
            Console.WriteLine(bA || bB); // True
            Console.WriteLine(!bB); // True
            Console.WriteLine(bB || true); // True
            Console.WriteLine((5 > 7) ^ (bA == bB)); // False

            int aaA = 0;
            int aaB = 1;
            
            var x = aaA > aaB ? 1 : 0;
            
            int r = (150-20) / 2 + 5;
// Expression for calculating the surface of the circle
            double surface = Math.PI * r * r;
// Expression for calculating the perimeter of the circle
            double perimeter = 2 * Math.PI * r;
            Console.WriteLine(r);
            Console.WriteLine(surface);
            Console.WriteLine(perimeter);

            int number = 1;
            string result = (number % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine(result);

            bool isDivisible = (number % 5 == 0) && (number % 7 == 0);
            
            MoonWeightCalculator calculator = new MoonWeightCalculator();
            calculator.CalculateMoonWeight();
            
            DigitReverser digitReverser = new DigitReverser();
            digitReverser.ReverseDigits();
            }
}