int[] numbers = { 3, 4, 10, 3, 5, 1, 3, 4, 9, 3, 2 };
int[] temp = new int[numbers.Length];
int uniqueCount = 0;

for (int i = 0; i < numbers.Length; i++)
{
    bool exists = false;

    for (int j = 0; j < uniqueCount; j++)
    {
        if (numbers[i] == temp[j])
        {
            exists = true;
            break;
        }
    }

    if (!exists)
    {
        temp[uniqueCount] = numbers[i];
        uniqueCount++;
    }
}

Array.Resize(ref temp, uniqueCount);

for (int i = 0; i < temp.Length; i++)
{
    Console.Write($"_({temp[i]})_");
}
