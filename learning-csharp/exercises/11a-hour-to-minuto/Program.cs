const float MINUTES_PER_HOURS = 60;

Console.Write("Digite uma quantidade de horas: ");
float hours = Convert.ToSingle(Console.ReadLine());

float result = hours * MINUTES_PER_HOURS;
Console.WriteLine($"{hours:.00} Horas = {result} Minutos");