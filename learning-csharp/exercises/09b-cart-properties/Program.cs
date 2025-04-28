Cart chart = new Cart();

chart.AddProduct("Air Fryer", 300f);
chart.AddProduct("Televisão", 3000.500f);
chart.AddProduct("Furadeira", 200f);
chart.AddProduct("Celular", 2000f);

Console.WriteLine($"""
Carrinho de Compras:
- Produtos: {chart.Count}
- Total: R$ {chart.Total}
""");