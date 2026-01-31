public class Circle
{
    public const float PI = 3.14159f;
    public const float HALF_CIRCLE = 180.0f;
    private const float DEGREES_TO_RADIANS_FACTOR = PI / HALF_CIRCLE;

    private float radius;

    public Circle(float radius)
    {
        this.radius = radius;
    }

    public float Area
    {
        get { return PI * (radius * radius); }
    }

    public float Circumference
    {
        get
        {
            const float CIRCUMFERENCE_MULTIPLIER = 2f;
            return CIRCUMFERENCE_MULTIPLIER * radius * PI;
        }
    }

    public static float ConvertDegreesToRadians(float degrees)
    {
        return degrees * DEGREES_TO_RADIANS_FACTOR;
    }
}