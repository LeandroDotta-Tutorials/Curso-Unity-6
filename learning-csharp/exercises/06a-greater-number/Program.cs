Console.Write("Digite o primeiro número: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o segundo número: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o terceiro número: ");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2 && number1 > number3)
{
    Console.WriteLine($"O maior número é {number1}");
}
else if (number2 > number1 && number2 > number3)
{
    Console.WriteLine($"O maior número é {number2}");
}
else
{
    Console.WriteLine($"O maior número é {number3}");
}