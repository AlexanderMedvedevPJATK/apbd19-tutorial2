Console.WriteLine("Hello, World!");
Console.WriteLine("Mod 1");
Console.WriteLine("Mod 2");
Console.WriteLine("Mod 3");

var numbers = new[] { 1, 2, 3, 4 };
Console.WriteLine(GetAverage(numbers));
Console.WriteLine(GetMax(numbers));

return;

static double GetAverage(int[] numbers)
{
    double sum = 0;
    foreach (var number in numbers)
    {
        sum += number;
    }

    return sum / numbers.Length;
}

static double GetMax(int[] numbers)
{
    var max = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] > max) max = numbers[i];
    }

    return max;
}