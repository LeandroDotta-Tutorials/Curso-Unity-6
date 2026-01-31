
Circle circle = new Circle(5.0f);

Console.WriteLine($"Área do Círculo = {circle.Area:.00}");
Console.WriteLine($"Circunferência do Círculo = {circle.Circumference:.00}");

float radians = Circle.ConvertDegreesToRadians(90);
Console.WriteLine($"Valor em radianos = {radians:.00}");

Console.WriteLine($"PI = {Circle.PI}");
Console.WriteLine($"Metade do Círculo = {Circle.HALF_CIRCLE}");