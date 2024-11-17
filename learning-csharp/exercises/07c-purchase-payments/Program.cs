Console.Write("Valor do produto: ");
float value = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("===== Tabela de Parcelas =====");
for (int i = 2; i <= 12; i++)
{
    Console.WriteLine($"{i}x de R${value / i:0.00}");
}