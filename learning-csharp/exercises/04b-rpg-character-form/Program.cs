Console.WriteLine("Bem-vindo ao centro de cadastros de personagens de RPG. Vamos registrar o seu personagem:");

Console.Write("Nome: ");
string name = Console.ReadLine();

Console.Write("HP (número): ");
int healthPoints = Convert.ToInt32(Console.ReadLine());

Console.Write("MP (número): ");
int manaPoints = Convert.ToInt32(Console.ReadLine());

Console.Write("Força (número): ");
int strength = Convert.ToInt32(Console.ReadLine());

Console.Write("Velocidade (número): ");
int speed = Convert.ToInt32(Console.ReadLine());

Console.Write("Altura (número): ");
float height = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Processando...");
Console.WriteLine($"""

Personagem registrado com sucesso!

- Nome: {name}
- HP: {healthPoints}
- MP: {manaPoints}
- Força: {strength}
- Velocidade: {speed}
- Altura: {height}

""");