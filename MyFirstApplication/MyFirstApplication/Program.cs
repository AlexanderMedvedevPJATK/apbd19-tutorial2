Console.WriteLine("Hello, World!");
Console.WriteLine("Mod 1");
Console.WriteLine("Mod 2");
Console.WriteLine("Mod 3");

var numbers = new[] { 1, 2, 3, 4 };
Console.WriteLine(GetAverage(numbers));

return;

static double GetAverage(int[] numbers)
{
    double sum = 0;
    foreach (var num in numbers)
    {
        sum += num;
    }

    return sum / numbers.Length;
}