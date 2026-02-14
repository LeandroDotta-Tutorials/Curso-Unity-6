Item[] items = {
    new Item("Epada", 10.5f, 1),
    new Item("Escudo", 15f, 1),
    new Item("Poção de Vida", 1.5f, 5),
    new Item("Amuleto", 150f, 1),
    new Item("Capacete", 30f, 2),
};

Console.WriteLine($"""
🎒 Inventário: 

| {"Item", -20} | {"Preço", 10} | {"Quantidade", 15} |
-------------------------------------------------------
""");

for (int i = 0; i < items.Length; i++)
{
    Console.WriteLine($"| {items[i].name,-20} | {items[i].price,10:.00} | {items[i].amount,15} |");
}