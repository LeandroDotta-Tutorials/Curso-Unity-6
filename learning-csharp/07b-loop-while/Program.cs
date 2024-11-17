int enemyHP = 0;

do
{
    enemyHP = enemyHP - 10;
    Console.WriteLine($"O jogador atacou o inimigo! HP do inimigo: {enemyHP}");
} while (enemyHP > 0);

Console.WriteLine("O inimigo foi derrotado!");