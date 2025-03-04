namespace BookExercises.week2;

public class Homework1
{
    byte positiveSmall = 97;
    byte smallPositive = 224;
    sbyte negativeSmall = -115;
    sbyte negativeSmallValue = -44;
    short negativeMedium = -10000;
    short smallYear = 1990;
    ushort positiveMedium = 20000;
    int largeNumber = 4825932;
    uint positiveLarge = 970700000;
    long veryLargeNegative = -1000000;

    ulong veryLargePositive = 123456789123456789;
    /*
    Signed types (sbyte, short, int, long) were used for negative values,
    while unsigned types (byte, ushort, uint, ulong) were chosen for positive
    values to maximize their range.

    For small values, byte was used to save memory.
    short and ushort were chosen for medium-sized values as they fit within
    their respective ranges.

    int was used for larger numbers since it's well within its range,
    while uint was suitable for larger positive values.

    long and ulong were necessary for very large values, ensuring they fit
    without overflow.

    These choices optimize memory usage and prevent unnecessary type conversions.
    */


    float num1 = 5f; // float can hold small integers with a suffix 'f'
    float num2 = -5.01f; // and supports up to 7 decimal digits
    double num4 = 12.345f;

    double num3 = 34.567839023; // double does not need any suffix
    double num5 = 8923.1234857; // and supports up to 15-16 digits

    decimal
        num6 = 3456.091124875956542151256683467m; // m stands for money which implies that decimal is mostly used for financial calculations
}