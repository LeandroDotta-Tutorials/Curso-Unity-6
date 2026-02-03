Transform player = new Transform(1, 1);
Transform enemy = new Transform(5, 5);

Board board = new Board();
Random random = new Random();
bool running = true;
int turnCount = 1;

while (running)
{
    PlayerTurn();
    EnemyTurn();

    turnCount += 1;
}

void PlayerTurn()
{
    Console.Clear();
    board.Draw(player, enemy, turnCount);

    Console.WriteLine($"┣ {Board.TILE_PLAYER} Vez do jogador");
    Action action = ActionMenu();

    switch (action)
    {
        case Action.Move:
        default:
            Direction direction = DirectionMenu();
            player.Move(direction);
            break;

        case Action.Attack:
            Console.WriteLine("┣💥 O Jogador ataca o Inimigo!");
            break;

        case Action.Exit:
            running = false;
            break;
    }

    EndTurn();
}

void EnemyTurn()
{
    Console.Clear();
    board.Draw(player, enemy, turnCount);

    Console.WriteLine($"┣ {Board.TILE_ENEMY} Vez do inimigo\n");
    EnemyState state = GetEnemyState();

    switch (state)
    {
        case EnemyState.Wandering:
            Direction direction = (Direction)random.Next(1, 5);
            enemy.Move(direction);
            Console.WriteLine($"┣💬 O Inimigo moveu para {direction} ({enemy.x}, {enemy.y})");
            break;

        case EnemyState.Following:
            enemy.Follow(player);
            Console.WriteLine($"┣💬 O Inimigo moveu em direção ao Player ({enemy.x}, {enemy.y})");
            break;

        case EnemyState.Attacking:
            Console.WriteLine($"┣💥 O Inimigo atacou o Jogador!");
            break;
    }

    EndTurn();
}

Action ActionMenu()
{
    Console.Write($"""
    ┏ 🎮 Ações:
    ┃ 
    ┃ {(int)Action.Move}) {Action.Move}
    ┃ {(int)Action.Attack}) {Action.Attack}
    ┃ {(int)Action.Exit}) {Action.Exit}
    ┃
    ┗ Escolha uma ação: 
    """);

    return (Action)Convert.ToInt32(Console.ReadLine());
}

Direction DirectionMenu()
{
    Console.Write($"""
    ┏ ↔️  Direção:
    ┃
    ┃ {(int)Direction.Up}) {Direction.Up}
    ┃ {(int)Direction.Down}) {Direction.Down}
    ┃ {(int)Direction.Left}) {Direction.Left}
    ┃ {(int)Direction.Right}) {Direction.Right}
    ┃
    ┗ Escolha uma direção: 
    """);

    return (Direction)Convert.ToInt32(Console.ReadLine());
}

EnemyState GetEnemyState()
{
    int distance = enemy.Distance(player);

    return distance switch
    {
        1 => EnemyState.Attacking,
        > 1 and <= 5 => EnemyState.Following,
        _ => EnemyState.Wandering
    };
}

void EndTurn()
{
    Console.WriteLine($"""

    ┏ Fim do turno!
    ┗ 👉🔵 Pressione uma tecla para continuar... 🔵👈
    """);
    Console.ReadKey();
}