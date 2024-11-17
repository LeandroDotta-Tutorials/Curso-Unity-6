Console.WriteLine("===== Inscrição Campeonato Mundial de Corrida! =====");

Console.Write("Número de vitórias em corridas oficiais: ");
int victoryCount = Convert.ToInt32(Console.ReadLine());

Console.Write("Quantos campeões regionais você venceu? -> ");
int regionChampions = Convert.ToInt32(Console.ReadLine());

Console.Write("Possui bilhete de inscrição instantânea? (s/n) -> ");
string input = Console.ReadLine();
bool hasTicket = input == "s" || input == "S";

if (victoryCount >= 50 && regionChampions >= 3 || hasTicket)
{
    Console.WriteLine("Inscrição realizada com sucesso!");
}
else
{
    Console.WriteLine("Você não possui os requisitos necessários para realizar a inscrição :(");
}