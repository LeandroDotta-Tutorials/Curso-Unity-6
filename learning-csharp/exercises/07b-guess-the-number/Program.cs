int number = 5;

Console.WriteLine("Adivinhe o número de 1 a 10");

int guess = -1;
while (guess != number)
{
    Console.Write("Digite o número: ");
    guess = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Parabéns, você acertou! O número é {guess}");