Console.Write("Quantos anos você tem? -> ");
int age = Convert.ToInt32(Console.ReadLine());

Console.Write("Você é gestante? (s/n): ");
string input = Console.ReadLine();
bool isPregnant = input == "s" || input == "S";

Console.Write("Você é PCD (Pessoa com Deficiência)? -> (s/n): ");
input = Console.ReadLine();
bool isPCD = input == "s" || input == "S";

if (age >= 60 || isPregnant || isPCD)
{
    Console.WriteLine("Atendimento Prioritário!");
}
else
{
    Console.WriteLine("Atendimento Comum!");
}
