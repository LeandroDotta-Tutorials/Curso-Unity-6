public class TaxCalculator
{
    public const float FIXED_TAX = 0.15f;

    public float CalculateProductPrice(float baseValue, ProductType type)
    {
        return baseValue + (baseValue * GetTax(type));
    }

    private float GetTax(ProductType type)
    {
        if (type == ProductType.Food || type == ProductType.Drug)
        {
            return 0;
        }
        else
        {
            return FIXED_TAX;
        }
    }
}