int[] numbers = { 3, 10, 50, 15, 120, 42 };

int min = 0;
int max = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (i == 0 || numbers[i] < min)
    {
        min = numbers[i];

    }

    if (i == 0 || numbers[i] > max)
    {
        max = numbers[i];
    }
}

Console.WriteLine($"""
-> Menor número: {min}
-> Maior número: {max}
""");