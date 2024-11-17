float gradeAverage = 0;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Aluno {i}");
    Console.Write("Nome: ");
    string name = Console.ReadLine();

    Console.Write("Nota: ");
    float grade = Convert.ToSingle(Console.ReadLine());

    gradeAverage = gradeAverage + grade;
    Console.WriteLine($"Alune \"{name}\" - Nota {grade}");
    Console.WriteLine("-------------------------------------");
}

Console.WriteLine($"A média de notas da turma foi: {gradeAverage / 10}");