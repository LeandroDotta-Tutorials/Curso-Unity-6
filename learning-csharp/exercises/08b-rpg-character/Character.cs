public class Character
{
    public string name;
    public int strength;
    public int agility;
    public int intelligence;

    private int healthPoints;

    public Character(int hp)
    {
        healthPoints = hp;
    }

    public void TakeDamage(int amount)
    {
        healthPoints = healthPoints - amount;
        Console.WriteLine($"O personagem {name} perdeu {amount} pontos de vida.");

        if (healthPoints <= 0)
        {
            Console.WriteLine($"O personagem {name} foi derrotado!");
        }
    }

    public void Print()
    {
        Console.WriteLine($"""
        
        ========== Personagem ==========
        - Nome: {name}
        - Força: {strength}
        - Agilidade: {agility}
        - Inteligência: {intelligence}
        
        """);
    }
}