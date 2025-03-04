class MoonWeightCalculator
{
    public void CalculateMoonWeight()
    {
        Console.Write("Enter your weight on Earth (kg): ");
        double earthWeight = Convert.ToDouble(Console.ReadLine());

        double moonWeight = earthWeight * 0.17;

        Console.WriteLine($"Your weight on the Moon would be: {moonWeight:F2} kg");
    }
}