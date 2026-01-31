TaxCalculator taxCalculator = new TaxCalculator();

float pastaPrice = taxCalculator.CalculateProductPrice(5.0f, ProductType.Food);
float medicinePrice = taxCalculator.CalculateProductPrice(200f, ProductType.Drug);
float laptopPrice = taxCalculator.CalculateProductPrice(5000f, ProductType.Eletonic);
float pantsPrice = taxCalculator.CalculateProductPrice(500f, ProductType.Clothing);

Console.WriteLine($"""
Tabela de Produtos

Imposto Fixo de {TaxCalculator.FIXED_TAX * 100:0}% nos produtos não isentos.

- Macarrão ({ProductType.Food}): R${pastaPrice:.00}
- Remédio ({ProductType.Drug}): R${medicinePrice:.00}
- Laptop ({ProductType.Eletonic}): R${laptopPrice:.00}
- Calça ({ProductType.Clothing}): R${pantsPrice:.00}

""");