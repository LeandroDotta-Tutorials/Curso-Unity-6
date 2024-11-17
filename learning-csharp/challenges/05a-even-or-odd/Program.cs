Console.Write("Digite um número: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine($"{number} é PAR");
}
else
{
    Console.WriteLine($"{number} é ÍMPAR");
}