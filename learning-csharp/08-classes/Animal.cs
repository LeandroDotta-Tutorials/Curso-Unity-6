public class Animal
{
    public string size;
    public string species;
    public string name;
    public int age;

    public Animal(string animalName)
    {
        name = animalName;
        Console.WriteLine($"Criando um objeto Animal com o nome {animalName}");
    }

    public void Eat()
    {
        Console.WriteLine($"O animal {name} está comendo...");
    }

    public int Move()
    {
        Console.WriteLine($"O animal {name} está se movendo...");

        if (size == "Pequeno")
        {
            return 2;
        }
        else if (size == "Médio")
        {
            return 5;
        }
        else if (size == "Grande")
        {
            return 10;
        }
        else
        {
            return 0;
        }
    }

    public void Play(Animal other)
    {
        Console.WriteLine($"O animal {name} está brincando com {other.name}");
    }

    public void Print()
    {
        Console.WriteLine($"""

        Animal:
        - Nome: {name}
        - Porte: {size}
        - Espécie: {species}
        - Idade: {age}

        """);
    }
}
