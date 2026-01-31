
Option option = Option.One;

while (option != Option.Exit)
{
    Console.Clear();
    Console.WriteLine($"""
    Um carro se aproxima do semáforo...

    Qual luz está acesa no momento?
    {(int)Option.One}) {TrafficLight.Green}
    {(int)Option.Two}) {TrafficLight.Yellow}
    {(int)Option.Three}) {TrafficLight.Red}
    {(int)Option.Exit}) Sair

    """);
    Console.Write("Escolhe a opção: ");
    option = (Option) Convert.ToInt32(Console.ReadLine());

    if (option == Option.One)
    {
        Console.WriteLine("🟢 Acelere");
    }
    else if (option == Option.Two)
    {
        Console.WriteLine("🟡 Atenção!");
    }
    else if (option == Option.Three)
    {
        Console.WriteLine("🛑 Pare!");
    }
    else if (option == Option.Exit)
    {
        Console.WriteLine("Bye Bye 👋🏽");
    }
    else
    {
        Console.WriteLine("Opção Inválida!");
    }

    Console.ReadKey();
}