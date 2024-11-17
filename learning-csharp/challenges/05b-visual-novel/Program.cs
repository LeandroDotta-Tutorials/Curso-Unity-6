Console.WriteLine("""

==================================================================================

Atenção Agente 008! Sua missão é infiltrar no escritório do magnata Don Corleone,
passando-se por parte da equipe de manutenção do edifício, e recuperar os arquivos
que provam sua participação no esquema de tráfico de entorpecentes!

==================================================================================

""");

Console.WriteLine("Você caminha em direção à porta de acesso do edifício, quando é interpelado pelo segurança.");
Console.WriteLine("— Sergurança: \"Preciso da sua identificação, por favor\"");

Console.WriteLine("""

-----------------------------------------------------------------------
O que você faz?

1) Apresenta a identificação falsa...
2) "Você sabe com quem está falando?"
3) Golpeia o segurança
4) "Preciso falar agora com a Srta. Sandiego!"

""");

Console.Write("Escolha uma opção: ");
int option = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("-----------------------------------------------------------------------");

if (option == 1)
{
    Console.WriteLine("""
    — Você: "Aqui está"
    Você entrega a identificação falsa.
    O segurança observa a identificação. Em seguida olha para você. Olha novamente para a identificação com um olhar desconfiado...
    Após alguns segundos tensos, ele devolve a identificação, e move-se para o lado permitindo que você passe.
    — Segurança: "Tenha um bom dia..."
    """);
}
else if (option == 2)
{
    Console.WriteLine("""
    — Você: "Você por um acaso sabe com quem está falando?"
    Com um olhar indignado, o segurança agarra você, imobilizando-o e rebate:
    — Segurança: "Cum um pé rapado que não sabe seu lugar e vai aprender uma lição..."
    """);

    return;
}
else if (option == 3)
{
    Console.WriteLine("""
    Você defere um golpe rápido, e o segurança cambaleia para trás, mas imediatamente reage e devolve
    o golpe, aplicando um soco que deixa você inconsciente.
    """);

    return;
}
else if (option == 4)
{
    Console.WriteLine("""
    — Você: "Preciso falar agora com a Srta. Sandiego. Saia da minha frente!"
    Você projeta seu corpo à frente com impaciência, mas é impedido pelo segurança, que
    o segura pelo braço, dizendo:
    — Segurança: "Espere um pouco! Não há nenhuma Srta. Sandiego aqui! Você vai ter que me acompanhar..."
    Ele leva você para fora do prédio...
    """);

    return;
}
else
{
    Console.WriteLine("""
    Você fica em silêncio e até que o segurança diz:
    — Segurança: "O que há de errado com você?! Venha comigo!"
    Ele leva você para fora do edifício...
    """);

    return;
}

Console.WriteLine("""
-------------------------------------------------------------------

Você adentra no edifício e digire-se rapidamente para o elevador de serviço, quando 
percebe dois homens de terno preto vindo em sua direção.

O que você faz?

1) Continua em direção ao elevador
2) Saca sua arma e dispara contra os homens
3) Vira o corredor em direção às escadas
4) Corre na direção oposta

""");

Console.Write("Escolha uma opção: ");
option = Convert.ToInt32(Console.ReadLine());

if (option == 1)
{
    Console.WriteLine("""
    Os homens que aparentavam estar distraídos, percebem sua presença e sacam suas armas:
    — Segurança: "Quem é você?! Você não tem permissão para estar aqui!"
    Eles redem você e o levam para sala de segurança enquanto chamam a polícia...
    """);
    return;
}
else if (option == 2)
{
    Console.WriteLine("""
    Os homens que estavam distraídos não percebem que você sacou a sua a arma a tempo para reagir.
    Você alveja um dos homens, mas erra o segundo tiro, acertando de raspão o braço do
        segundo homen, que saca a sua arma e dispara vários tiros contra você...
    """);

    return;
}
else if (option == 3)
{
    Console.WriteLine("""
    Você rapidamente vira à esquerda, em direção as escadas, passando desapercebido pelos homens
    e perdendo-os de vista.
    """);
}
else if (option == 4)
{
    Console.WriteLine("""
    Você dispara na direção oposta, chamando atenção do dois homens que correm em sua direção enquanto
    um deles também fala no rádio, pedindo por reforços.
    Um pouco a frente, um terceiro homen, surge a sua frente, impedindo sua passagem. Eles imobilizam
    você e te levam para a sala de segurança, enquanto chamam a polícia...
    """);
    return;
}
else
{
    Console.WriteLine("""
    Você fica em silêncio e até que o segurança diz:
    — Segurança: "O que há de errado com você?! Venha comigo!"
    Ele leva você para fora do edifício...
    """);
    return;
}