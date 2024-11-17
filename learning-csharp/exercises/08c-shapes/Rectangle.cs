public class Rectangle
{
    public float height;
    public float width;

    public Rectangle(float height, float width)
    {
        this.height = height;
        this.width = width;
    }

    public float Area()
    {
        return height * width;
    }

    public float Perimeter()
    {
        return (height + width) * 2;
    }
}