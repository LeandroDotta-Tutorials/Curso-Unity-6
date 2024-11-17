Console.WriteLine("===== Gerador de Personagens =====");

Character character = new Character(100);

Console.Write("Nome: ");
character.name = Console.ReadLine();

Console.Write("Força: ");
character.strength = Convert.ToInt32(Console.ReadLine());

Console.Write("Agilidade: ");
character.agility = Convert.ToInt32(Console.ReadLine());

Console.Write("Inteligência: ");
character.intelligence = Convert.ToInt32(Console.ReadLine());

character.Print();

character.TakeDamage(10);
character.TakeDamage(30);
character.TakeDamage(40);
character.TakeDamage(10);
character.TakeDamage(10);