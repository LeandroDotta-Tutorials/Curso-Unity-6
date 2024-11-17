public class Circle
{
    public float radius;

    public Circle(float radius)
    {
        this.radius = radius;
    }

    public float Area()
    {
        return 3.141f * (radius * radius);
    }

    public float Perimeter()
    {
        return 2 * 3.141f * radius;
    }
}