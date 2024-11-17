Animal monkey = new Animal("Orangotango")
{
    size = "Médio",
    species = "Orangotango-de-bornéu",
    age = 30
};

Animal macaw = new Animal("Arara-Azul")
{
    size = "Pequeno",
    species = "A. hyacinthinus",
    age = 25
};

Animal giraffe = new Animal("Girafa")
{
    size = "Grande",
    species = "Giraffa camelopardalis",
    age = 15
};

monkey.Print();
macaw.Print();
giraffe.Print();

monkey.Eat();
macaw.Eat();
giraffe.Eat();

int distance = monkey.Move();
Console.WriteLine($"Distância percorrida por {monkey.name}: {distance} metros");

distance = macaw.Move();
Console.WriteLine($"Distância percorrida por {macaw.name}: {distance} metros");

distance = giraffe.Move();
Console.WriteLine($"Distância percorrida por {giraffe.name}: {distance} metros");

macaw.Play(giraffe);