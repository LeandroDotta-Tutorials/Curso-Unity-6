Console.Write("Digite o nome do produto: ");
string product = Console.ReadLine();

Console.Write("Preço do produto: ");
float price = Convert.ToSingle(Console.ReadLine());

Console.Write("Quantidade em estoque: ");
int amount = Convert.ToInt32(Console.ReadLine());

float discount = 1;

if (amount < 10)
{
    discount = 0.05f;
}
else if (amount >= 10 && amount < 50)
{
    discount = 0.1f;
}
else if (amount >= 50 && amount < 1000)
{
    discount = 0.12f;
}
else if (amount >= 1000)
{
    discount = 0.15f;
}

float priceWithDiscount = price - (price * discount);

Console.WriteLine($"Preço com {100 * discount:0}% é R${priceWithDiscount}");