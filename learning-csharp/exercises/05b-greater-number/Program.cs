Console.Write("Digite o primeiro número: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o segundo número: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine($"{number1} é MAIOR");
}
else
{
    Console.WriteLine($"{number2} é MAIOR");
}