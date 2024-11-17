Console.Write("Digite um número: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite a porcentagem (1 - 100): ");
int percentage = Convert.ToInt32(Console.ReadLine());

int result = number * percentage / 100;

Console.WriteLine($"{percentage}% de {number} = {result}");