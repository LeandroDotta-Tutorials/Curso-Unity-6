string[] names = new string[5];

for (int i = 0; i < names.Length; i++)
{
    Console.Write($"{i + 1}) Digite um nome: ");
    names[i] = Console.ReadLine();
}

Array.Sort(names);
Array.Reverse(names);

for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine($"-> {names[i]}");
}