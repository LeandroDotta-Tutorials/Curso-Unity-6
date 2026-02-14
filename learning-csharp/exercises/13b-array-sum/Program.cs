float[] numbers = { 5.5f, 10f, 2.3f, 55.7f, 15f };

float sum = 0f;

for (int i = 0; i < numbers.Length; i++)
{
    sum = sum + numbers[i];
}

Console.WriteLine($"Soma do Array: {sum}");