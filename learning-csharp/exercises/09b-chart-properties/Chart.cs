public class Chart
{
    public int Count { get; private set; }
    public float Total { get; private set; }

    public void AddProduct(string product, float value)
    {
        Count++;

        Total += value;
    }
}