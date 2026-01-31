Difficult difficult = Difficult.Hard;

float healthPoints;
float attackPoints;
float defensePoints;

if (difficult == Difficult.Easy)
{
    healthPoints = 10f;
    attackPoints = 1.5f;
    defensePoints = 5.0f;
}
else if (difficult == Difficult.Medium)
{
    healthPoints = 25f;
    attackPoints = 3.5f;
    defensePoints = 7.0f;
}
else
{
    healthPoints = 150f;
    attackPoints = 10f;
    defensePoints = 30f;
}

Console.WriteLine($"""
Atributos do Inimigo no modo "{difficult}"

- HP: {healthPoints}
- Attack: {attackPoints}
- Defense: {defensePoints}

""");