Scoreboard scoreboard = new Scoreboard("Fulano", "Beltrano", 5);

Console.WriteLine("Iniciando partida...");

bool gameOver = false;

while (!gameOver)
{
    Console.Write("Qual jogador pontuous? -> ");
    int player = Convert.ToInt32(Console.ReadLine());

    gameOver = scoreboard.AddScore(player, 1);
}

Player winner = scoreboard.GetWinner();
Console.WriteLine($"Fim de jogo! {winner.name} venceu! 🎉");