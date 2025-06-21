
int[] numbers = { 2, 4, 6, 8, 10 };
double avg = CalculateAverage(numbers);
Console.WriteLine($"Średnia: {avg}");


static double CalculateAverage(int[] numbers)
{
    if (numbers == null || numbers.Length == 0)
        return 0;

    int sum = 0;
    foreach (int num in numbers)
        sum += num;

    return (double)sum / numbers.Length;
}

int zmienna;

public static int FindMax(int[] numbers) =>
    numbers.Max();