int healthPoints = 100;
int weakAttack = 10;
int strongAttack = 30;

healthPoints = healthPoints - weakAttack;
Console.WriteLine($"Você recebeu um ataque e perdeu {weakAttack} pontos de vida");

healthPoints = healthPoints - strongAttack;
Console.WriteLine($"Você recebeu um ataque e perdeu {strongAttack} pontos de vida");

Console.WriteLine($"HP: {healthPoints}");