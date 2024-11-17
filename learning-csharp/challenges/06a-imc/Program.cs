Console.Write("Altura (metros): ");
float height = Convert.ToSingle(Console.ReadLine());

Console.Write("Peso (Kg): ");
float weight = Convert.ToSingle(Console.ReadLine());

float imc = weight / (height * height);

string classification = "";

if (imc < 18.5f)
{
    classification = "Abaixo do peso";
}
else if (imc >= 18.5f && imc < 25f)
{
    classification = "Peso normal";
}
else if (imc >= 25f && imc < 30f)
{
    classification = "Sobrepeso";
}
else if (imc >= 30f && imc < 35f)
{
    classification = "Obesidade grau I";
}
else if (imc >= 35f && imc < 40f)
{
    classification = "Obesidade grau II";
}
else if (imc >= 40f && imc < 50f)
{
    classification = "Obesidade grau III";
}
else if (imc >= 50f && imc < 60f)
{
    classification = "Obesidade grau IV";
}
else if (imc >= 60f)
{
    classification = "Obesidade grau V";
}

Console.WriteLine($"""
=========== Resultado ===========
IMC: {imc}
Classificação: {classification}
=================================
""");