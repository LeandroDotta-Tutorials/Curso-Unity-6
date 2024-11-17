Console.Write("Digite o primeiro número: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o segundo número: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Resultado dos Cálculos: ");
Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
Console.WriteLine($"{number1} X {number2} = {number1 * number2}");
Console.WriteLine($"{number1} ÷ {number2} = {number1 / number2}");