int balance = 2000;

if (balance >= 1000)
{
    balance = balance - 1000;
    Console.WriteLine("Parabéns. Você comprou a espada!");
}
else
{
    Console.WriteLine("Você não tem moedas suficientes para comprar a espada");
}

Console.WriteLine($"Saldo do jogador: {balance}");