Rectangle rect = new Rectangle(10, 5);

float area = rect.Area();
Console.WriteLine($"Área do retângulo: {area}");

float perimeter = rect.Perimeter();
Console.WriteLine($"Perímetro do retângulo: {perimeter}");
Console.WriteLine("--------------------------------------------");

Circle circle = new Circle(5);

area = circle.Area();
Console.WriteLine($"Área do círculo: {area}");

perimeter = circle.Perimeter();
Console.WriteLine($"Perímetro do círculo: {perimeter}");
Console.WriteLine("--------------------------------------------");

Triangle triangle = new Triangle(10, 10, 10);

perimeter = triangle.Perimeter();
Console.WriteLine($"Perímetro do triângulo: {perimeter}");

string type = triangle.Type();
Console.WriteLine($"Tipo do triângulo: {type}");