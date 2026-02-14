int[] primeNumbers = { 2, 3, 5, 7, 11, 13, 17, 19 };


primeNumbers[0] = 50;
primeNumbers[6] = 999;

Array.Reverse(primeNumbers);

Console.WriteLine("""

==============================
Números Primos
==============================

""");

for (int i = 0; i < primeNumbers.Length; i++)
{
    Console.WriteLine(primeNumbers[i]);
}

Console.WriteLine("""

==============================
Múltiplos
==============================

""");

int[] multiplesOf = new int[15];

for (int i = 0; i < multiplesOf.Length; i++)
{
    multiplesOf[i] = (i + 1) * 5;
    Console.WriteLine(multiplesOf[i]);
}

Console.WriteLine("""

==============================
Nomes
==============================

""");

string[] names = { "Leandro", "Lucy", "Maria", "José", "Enzo", "Jurema", "Astolfo" };

Array.Sort(names);

for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}