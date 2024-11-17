// Igual
int x = 10;
int y = 10;

if (x == y)
{
    Console.WriteLine($"{x} É IGUAL a {y}");
}

// Não-igual (diferente)
string player1 = "Leandro";
string player2 = "Lucy";

if (player1 != player2)
{
    Console.WriteLine($"{player1} NÃO É IGUAL à {player2}");
}

// Maior que
int age1 = 30;
int age2 = 20;

if (age1 > age2)
{
    Console.WriteLine($"{age1} anos é MAIOR que {age2} anos");
}

// Maior ou igual que
if (age1 >= age2)
{
    Console.WriteLine($"{age1} anos é MAIOR OU IGUAL à {age2} anos");
}

// Menor
if (age1 < age2)
{
    Console.WriteLine($"{age1} anos é MENOR que {age2} anos");
}

// Menor ou igual que
if (age1 <= age2)
{
    Console.WriteLine($"{age1} anos é MENOR OU IGUAL à {age2} anos");
}