Console.Write("Digite uma Categoria de Jogo: ");
string input = Console.ReadLine();

if (Enum.TryParse<GameCategory>(input, true, out var category))
{
    Console.WriteLine($"Categoria Digitada: {category}");
}
else
{
    Console.WriteLine($"'{input}' é um categoria inválida");
}

