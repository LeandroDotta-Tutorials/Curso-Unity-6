using System.Text;

string[] words = new string[5];
string[] wordsWithoutVowel = new string[5];

for (int i = 0; i < words.Length; i++)
{
    Console.Write($"{i + 1}) Digite uma palavra: ");
    words[i] = Console.ReadLine();
    wordsWithoutVowel[i] = RemoveVowels(words[i]);
}

Console.WriteLine($"""

| {"ORIGINAL",-10} | {"SEM VOGAIS",-10} |
============================
""");

for (int i = 0; i < words.Length; i++)
{
    Console.WriteLine($"| {words[i],-10} | {wordsWithoutVowel[i],-10} |");
}

string RemoveVowels(string text)
{
    StringBuilder result = new StringBuilder();

    for (int i = 0; i < text.Length; i++)
    {
        var letter = text[i];

        if (letter != 'a' && letter != 'e' && letter != 'i' && letter != 'o' && letter != 'u' &&
            letter != 'A' && letter != 'E' && letter != 'I' && letter != 'O' && letter != 'U')
        {
            result.Append(letter);
        }
    }

    return result.ToString();
}