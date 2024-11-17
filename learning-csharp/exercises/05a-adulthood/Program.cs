Console.Write("Informe seu nome: ");
string name = Console.ReadLine();

Console.Write("Informe sua idade: ");
int age = Convert.ToInt32(Console.ReadLine());

Console.Write($"Olá {name}.");

if (age >= 18)
{
    Console.WriteLine("Você é maior de idade");
}
else
{
    Console.WriteLine("Você é menor de idade");
}