public class Triangle
{
    public float a;
    public float b;
    public float c;
    
    public Triangle(float a, float b, float c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public float Perimeter()
    {
        return a + b + c;
    }

    public string Type()
    {
        if (a != b && a != c && b != c)
        {
            return "Escaleno";
        }
        else if (a == b && a == c)
        {
            return "Equilátero";
        }
        else 
        {
            return "Isóceles";
        }
    }
}