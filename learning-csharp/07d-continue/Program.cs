int number = 6;
int numberToSkip = 9;

for (int i = 1; i <= 10; i++)
{
    if (i == numberToSkip)
    {
        Console.WriteLine($"PULANDO O NÚMERO {numberToSkip}");
        continue;
    }

    Console.WriteLine($"{number}x{i} = {number * i}");
}

