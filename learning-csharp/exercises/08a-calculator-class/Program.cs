Console.Write("Digite o primeiro número: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o segundo número: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("========================================");
Calculator calc = new Calculator();

int sum = calc.Sum(number1, number2);
Console.WriteLine($"Soma: {sum}");

int sub = calc.Subtract(number1, number2);
Console.WriteLine($"Subtração: {sub}");

int mult = calc.Multiply(number1, number2);
Console.WriteLine($"Multiplicação: {mult}");

int div = calc.Divide(number1, number2);
Console.WriteLine($"Divisão: {div}");