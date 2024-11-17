Console.WriteLine("Calculadora de Tempo de percurso!");

Console.Write("Digite a distância (Km): ");
float distance = Convert.ToSingle(Console.ReadLine());

Console.Write("Digite a velocidade (Km/h): ");
float speed = Convert.ToSingle(Console.ReadLine());

float time = distance / speed * 60;

Console.WriteLine($"São necessários {time} minutos para percorrer {distance}km à {speed}km/h");