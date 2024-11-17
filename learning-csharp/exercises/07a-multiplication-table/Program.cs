Console.Write("Digite um número: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{number}x{i} = {number * i}");
}