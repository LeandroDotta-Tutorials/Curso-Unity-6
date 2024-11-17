Console.Write("Digite a operação que deseja realizar (sum, sub, mult, div): ");
string operation = Console.ReadLine();

Console.Write("Digite o primeiro número: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o segundo número: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (operation == "sum")
{
    Console.WriteLine($"Resultado: {number1 + number2}");
}
else if (operation == "sub")
{
    Console.WriteLine($"Resultado: {number1 - number2}");
}
else if (operation == "mult")
{
    Console.WriteLine($"Resultado: {number1 * number2}");
}
else if (operation == "div")
{
    Console.WriteLine($"Resultado: {number1 / number2}");
}
else
{
    Console.WriteLine("Operação Inválida");
}