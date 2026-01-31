const float EXCHANGE_RATE = 5.27f;
const float IOF_RATE = 0.0538f;

Console.Write("Digite um valor em Real (BRL): ");
float real = Convert.ToSingle(Console.ReadLine());

float dollar = real * EXCHANGE_RATE;
float iof = dollar * IOF_RATE;
float total = dollar + iof;

Console.WriteLine($"""
- Real: R${real}
- Dollar: ${dollar}
- IOF: {iof}
- Total: {total}
""");