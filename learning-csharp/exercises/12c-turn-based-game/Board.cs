public class Board
{
    private const int SIZE = 10;
    public const string TILE_PLAYER = "🤠";
    public const string TILE_ENEMY = "👺";
    public const string TILE_EMPTY = "⬛";

    public void Draw(Transform player, Transform enemy, int turn)
    {
        for (int y = SIZE - 1; y >= 0; y--)
        {
            for (int x = 0; x < SIZE; x++)
            {
                if (player.x == x && player.y == y)
                {
                    Console.Write(TILE_PLAYER);
                }
                else if (enemy.x == x && enemy.y == y)
                {
                    Console.Write(TILE_ENEMY);
                }
                else
                {
                    Console.Write(TILE_EMPTY);
                }
            }

            Console.WriteLine();
        }

        Console.WriteLine($"""
        ┏━━━━━━━━━━━━━┓
        ┃ TURNO {turn}
        ┗━━━━━━━━━━━━━┛
        """);
    }
}