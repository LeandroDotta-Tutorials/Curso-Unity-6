float[] numbers = new float[5];

float sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{i + 1}) Digite um número: ");
    numbers[i] = Convert.ToSingle(Console.ReadLine());
    sum = sum + numbers[i];
}

Console.WriteLine($"Média aritmética: {sum / numbers.Length}");