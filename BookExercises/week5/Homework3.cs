namespace BookExercises.week5;

public class Homework3
{
    private readonly string[] ones =
    {
        "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
        "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen",
        "seventeen", "eighteen", "nineteen"
    };

    private readonly string[] tens =
    {
        "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"
    };

    public string Convert(int number)
    {
        if (number < 0 || number > 999)
            return "Number out of range";

        if (number == 0)
            return "Zero";

        string result = "";

        if (number >= 100)
        {
            result += ones[number / 100] + " hundred";
            number %= 100;
            if (number > 0)
                result += " and ";
        }

        if (number > 0)
        {
            if (number < 20)
            {
                result += ones[number];
            }
            else
            {
                result += tens[number / 10];
                if (number % 10 > 0)
                    result += " " + ones[number % 10];
            }
        }

        return char.ToUpper(result[0]) + result.Substring(1);
    }
}

