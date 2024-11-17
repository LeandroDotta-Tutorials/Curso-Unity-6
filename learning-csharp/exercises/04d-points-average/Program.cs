Console.WriteLine("Digite a pontuação das últimas 5 partidas: ");

Console.Write("Partida 1: ");
int score = Convert.ToInt32(Console.ReadLine());

Console.Write("Partida 2: ");
score = score + Convert.ToInt32(Console.ReadLine());

Console.Write("Partida 3: ");
score = score + Convert.ToInt32(Console.ReadLine());

Console.Write("Partida 4: ");
score = score + Convert.ToInt32(Console.ReadLine());

Console.Write("Partida 5: ");
score = score + Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A média de pontos é: {score / 5}");