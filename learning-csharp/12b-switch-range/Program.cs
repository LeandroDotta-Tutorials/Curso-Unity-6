float distance = 5000;

switch (distance)
{
    case >= 0 and < 25.0f:
        Console.WriteLine("Muito perto!");
        break;

    case >= 25.0f and < 100.0f:
        Console.WriteLine("Distância rasoável!");
        break;

    case >= 100.0f and < 100000.0f:
        Console.WriteLine("Muito longe!");
        break;

    case < 0f:
    case >= 100000.0f:
        Console.WriteLine("Distância fora de alcance!");
        break;

    case float.NaN:
        Console.WriteLine("Isso nem é um número!");
        break;
}