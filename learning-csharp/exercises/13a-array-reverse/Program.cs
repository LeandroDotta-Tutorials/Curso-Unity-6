int[] numbers = new int[10];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = i + 1;
}

for (int i = numbers.Length - 1; i >= 0; i--)
{
    Console.Write($"{numbers[i]} - ");
}