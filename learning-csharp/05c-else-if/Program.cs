int level = -1;

if (level == 1)
{
    Console.WriteLine("Você ganhou uma skin!");
}
else if (level == 2)
{
    Console.WriteLine("Você ganhou uma armadura");
}
else if (level == 3)
{
    Console.WriteLine("Você ganhou uma habilidade rara!");
}
else if (level >= 4)
{
    Console.WriteLine("Você ganhou um sele raro!");
}
else
{
    Console.WriteLine("Nenhum prêmio");
}