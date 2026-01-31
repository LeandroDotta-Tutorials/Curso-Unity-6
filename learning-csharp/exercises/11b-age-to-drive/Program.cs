const int MINIMUM_AGE_TO_DRIVE = 18;

Console.Write("Digite sua idade: ");
int age = Convert.ToInt32(Console.ReadLine());

if (age > MINIMUM_AGE_TO_DRIVE)
{
    Console.WriteLine("Você pode dirigir");
}
else
{
    Console.WriteLine("Você NÃO tem permissão para dirigir!");
}