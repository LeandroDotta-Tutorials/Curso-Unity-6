int level = 10;
bool hasKey = true;
int coins = 500;
int items = 15;

if ((hasKey && level >= 10) || (coins >= 1000 && items > 10))
{
    Console.WriteLine("Você desbloqueou uma nova área!");
}