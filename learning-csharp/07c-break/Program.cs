int coins = 0;
int rewardsReceived = 0;

Console.WriteLine($"Saldo inicial: {coins}");

while (coins < 1000)
{
    coins = coins + 100;
    rewardsReceived++;

    Console.WriteLine($"Você recebeu a recompença {rewardsReceived}");

    if (rewardsReceived == 5)
    {
        break;
    }
}

Console.WriteLine("Obrigado pela preferência. Volte sempre!");