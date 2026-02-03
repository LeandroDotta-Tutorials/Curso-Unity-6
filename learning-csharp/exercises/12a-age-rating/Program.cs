Console.Write("Digite uma idade: ");
int age = Convert.ToInt32(Console.ReadLine());

# region Comando swith padrão
switch (age)
{
    case > 0 and <= 13:
        Console.WriteLine("Criança");
        break;
    case > 13 and <= 18:
        Console.WriteLine("Adolescente");
        break;
    case > 18 and <= 60:
        Console.WriteLine("Adulto");
        break;
    case > 60 and <= 150:
        Console.WriteLine("Idoso");
        break;
    default:
        Console.WriteLine("Idade Inválida");
        break;
}
# endregion

# region Switch expression
string classification = age switch
{
    > 0 and <= 13   => "Criança",
    > 13 and <= 18  => "Adolescente",
    > 18 and <= 60  => "Adulto",
    > 60 and <= 150 => "Idoso",
    _               => "Inválido"
};

Console.WriteLine($"Classificação Etária ({age} anos): {classification}");
#endregion