Console.WriteLine("Classificatórias de Basquete!");

Console.Write("Nome do time: ");
string team = Console.ReadLine();

int victoryCount = 0;
int totalScore = 0;

Console.WriteLine("Placar do Jogo 1: ");
Console.Write("Pontos do seu time: ");
int teamScore = Convert.ToInt32(Console.ReadLine());
Console.Write("Pontos do time adversário: ");
int opponentScore = Convert.ToInt32(Console.ReadLine());

if (teamScore > opponentScore)
{
    victoryCount = victoryCount + 1;
}

totalScore = teamScore - opponentScore;

Console.WriteLine("Placar do Jogo 2: ");
Console.Write("Pontos do seu time: ");
teamScore = Convert.ToInt32(Console.ReadLine());
Console.Write("Pontos do time adversário: ");
opponentScore = Convert.ToInt32(Console.ReadLine());

if (teamScore > opponentScore)
{
    victoryCount = victoryCount + 1;
}

totalScore = totalScore + (teamScore - opponentScore);


Console.WriteLine("Placar do Jogo 3: ");
Console.Write("Pontos do seu time: ");
teamScore = Convert.ToInt32(Console.ReadLine());
Console.Write("Pontos do time adversário: ");
opponentScore = Convert.ToInt32(Console.ReadLine());

if (teamScore > opponentScore)
{
    victoryCount = victoryCount + 1;
}

totalScore = totalScore + (teamScore - opponentScore);
int averageScore = totalScore / 3;

Console.WriteLine($"""

===== Classificação do time {team} =====

Vitórias: {victoryCount}
Saldo de Pontos: {totalScore}
Média do Saldo: {averageScore}

""");

if (victoryCount >= 2)
{
    Console.WriteLine($"O time {team} está classficado!");
}
else
{
    Console.WriteLine($"O time {team} NÃO está classficado!");
}