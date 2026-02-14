const int SIZE = 5;

Random random = new Random();

float[] sequence1 = new float[SIZE];
float[] sequence2 = new float[SIZE];
float[] sums = new float[SIZE];

for (int i = 0; i < SIZE; i++)
{
    sequence1[i] = random.NextSingle() * 100;
    sequence2[i] = random.NextSingle() * 100;
}

for (int i = 0; i < SIZE; i++)
{
    int indexEnd = SIZE - 1 - i;
    sums[i] = sequence1[i] + sequence2[indexEnd];

    Console.WriteLine($" -> [{i}] {sequence1[i], 10} ➕ [{indexEnd}] {sequence2[indexEnd], 10} 🟰 {sums[i], 10} ");
}