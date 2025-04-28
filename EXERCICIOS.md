# Lista de Exercícios & Desafios do Curso de Unity 6

Os exercícios & desafios estão agrupados por "Exercícios de C#" para os exercícios das aulas de C# e "Exercícios de Projeto" para exercícios relacionados aos projetos Unity.

# Exercícios de C#

## Módulo 1

### C# Básico - Variáveis

- **Vídeo da Aula**: https://youtu.be/amT0czaPdCs
- **Vídeo de Solução**: https://youtu.be/4xnXERo_Suw

#### Exercícios

**A)** Crie um programa que faça as operações de soma, subtração, multiplicação e divisão de dois números reais (`float`) e mostre os resultados no Console.

**B)** Crie um programa que mostre a tabuada de um número no Console. Você precisa definir uma variável com o número que será utilizado para a tabuada e multiplicá-lo por números de 1 a 10.

**C)** Considere um jogo em que o jogador controla um personagem que possui barra de vida, e que esse personagem perde pontos de vida quando ele recebe ataques de seus inimigos. Crie um programa que simule a seguinte situação: o personagem começa com 100 pontos de vida (HP ou healthPoints) e ele perde 10 pontos de vida ao receber o primeiro ataque de um inimigo. Em seguida ele toma um segundo ataque mais poderoso, que faz com que ele perca 30 pontos de vida. A cada ataque recebido, mostre uma mensagem no Console quantos pontos de vida o personagem perdeu.

**D)** Considere um jogo de RPG em que o jogador pode criar seus próprios personagens, atribuindo suas características. Cria um programa em C# em que o jogador vai cadastrar os seguintes atributos do seu personagem:

- nome (`string`)
- altura (`float`)
- força (`int`)
-  agilidade (`int`)
- inteligência (`int`)
- é um herói ou vilão (`bool`)

Ao fim, mostre uma mensagem descrevendo todos os atributos do personagem do jogador

#### Desafios

**A)** Crie um programa que calcule o resto da divisão de um número.

**B)** Crie um programa que possua uma variável que calcule a seguinte operação _“10 + 20 - 10 * 2”_. O resultado será _“10”_. Em seguida, modifique a equação para que ela calcule exatamente os mesmos número, sem mudar a ordem, mas o resultado seja _“40”_.

### C# Básico - Strings

- **Vídeo da Aula**: https://youtu.be/ppTTNQ9Xskg
- **Vídeo de Solução**: https://youtu.be/QshJ6doKvzA

#### Exercícios

**A)** Considere um jogo em que o jogador precisa realizar diversas missões como derrotar uma quantidade de inimigos ou coletar uma quantidade de items. Crie um programa C# que escreva no Console a seguinte lista de missões:
    
- Derrote os goblins da montanha (5);
- Colete os frutos vermelhos para criar uma poção de HP (10);
- Colete joias do caos para forjar uma espada poderosa (3);
- Derrote todos os ogros do pântano (25);
- Destrua as bandeiras do clã inimigo (5).
    
_As quantidades para cada missão, devem ser definidas através de variáveis_

#### Desafios

**A)** Crie um program que escreva um texto com dois parágrafos longos no Console (com pelo menos 50 palavras cada) utilizando apenas um comando `Console.WriteLine` e sem criar variáveis. O texto deve aparecer no Console de forma que os dois parágrafos estejam separados com quebra de linha.
    
**Dica:** Pesquise _"Raw string literal"_


**B)** Crie um programa em C# que escreva o texto _"Don’t Panic!"_ e em seguida mostre quantos caracteres esse texto possui.

**Dica:** Existe uma forma de descobrir quantos caracteres uma variável string possui.

### C# Básico - Input/Output

- **Vídeo da Aula**: https://youtu.be/o-TA-IcPgUw
- **Vídeo de Solução**: https://youtu.be/sU945nC5z6M

#### Exercícios

**A)** Crie um programa para calcular as operações de soma, subtração, multiplicação e divisão entre dois números informados pelo usuário.

**B)** Personagem de RPG: Crie um programa para cadastrar os atributos de uma personagem de RPG. Primeiro peça que o jogador informe o nome da sua personagem. Em seguida peça que o jogador informe os seguintes atributos:
- Pontos de vida (HP); 
- Pontos de Mana (MP);
- Força;
- Velocidade;
- Altura;
    
Finalmente, apresente as informações do personagem no Console.

**C)** Crie um programa que calcule a porcentagem de um número escolhido pelo usuário. Primeiro, peça que o usuário digite um número. Em seguida, peça que ele digite a porcentagem a ser calculada (de 1 a 100). Mostre o resultado no Console.

**D)** Considere um jogo em que o jogador recebe uma pontuação a cada partida. Crie um programa que receba a pontuação das últimas 5 partidas e mostre a média de pontos do jogador.

**E)** Crie um programa que calcule o tempo necessário para percorrer uma distância. Primeiro, peça que o usuário informe uma distância (em quilômetros) e, em seguida, peça que o usuário informe uma velocidade (em km/h). Mostre no Console quantos minutos são necessários para percorrer a distância informada.

### C# Básico - Fluxos de Controle

- **Vídeo da Aula**: https://youtu.be/yw3MnDVdI58
- **Vídeo de Solução**: https://youtu.be/ZAbWwIVeQeA

#### Exercícios

**A)** Crie um programa que pergunte o nome e a idade de uma pessoa e mostre um texto no Console indicando se ela é maior ou menor de idade.

**B)** Crie um programa que pergunte dois números ao usuário e mostre no Console qual é o maior número.

**C)** Crie uma calculadora em que o usuário escolhe o tipo de operação a ser feita. Primeiro, peça que o usuário escolha qual operação deve ser realizada (soma, subtração, multiplicação ou divisão). Em seguida, peça que o usuário informe os dois números que serão calculados. Mostre no Console o resultado da operação escolhida entre os dois números.

**D)** Considere um campeonato de basquete em que, para ser classificado, um time precisa vencer 2 de 3 partidas. Crie um programa que peça para o usuário preencher o placar de 3 jogos de um time e mostre uma mensagem no Console informando quantos jogos o time venceu, qual é seu saldo de pontos e uma mensagem informando se ele foi classificado ou não.

#### Desafios

**A)** Crie um programa em que o usuário digite um número e mostre se o número é par ou ímpar.

**B)** Crie um jogo texto no estilo Visual Novel em que o jogador interage com um personagem e deve escolher as respostas corretas para concluir um objetivo. Por exemplo: imagine que o jogador é um espião que deve convencer o segurança a deixá-lo passar por uma porta que ele não deveria ter acesso. Nesse exemplo, o segurança faz uma pergunta como "Preciso da sua identificação, por favor", e algumas opções de ação são apresentadas ao jogador, como:

    1. Apresentar identificação falsa…
    2. "Você sabe com quem está falando?"
    3. Golpear o segurança...
    4. "Preciso falar com a Srta Sandiego"
    
Utilize o comando `Console.ReadLine()` para aguardar a resposta do jogador e utilize o comando `if` para determinar se a opção escolhida pelo jogador é a correta.

Seja criativo, crie situações e diálogos que deixem seu jogo interessante.

### C# Básico - Operadores Lógicos

- **Vídeo da Aula**: https://youtu.be/pnzp4Hvlnco
- **Vídeo de Solução**: https://youtu.be/SJF9BgmkHXI

#### Exercícios

**A)** Crie um programa que peça para o usuário informar 3 números e informe qual é o maior.

**B)** Crie um programa para calcular o desconto de um produto baseado na quantidade em estoque. Primeiro peça que o usuário informe o nome do produto, em seguida, o preço do produto e, finalmente a quantidade desse produto em estoque. Mostre no Console qual é a porcentagem do desconto e qual é o valor com desconto, de acordo com os seguintes critérios:

| Quantidade                     | Desconto |
| ------------------------------ | -------- |
| Menos de 10 itens no estoque   | 5%       |
| De 10 à 50 itens no estoque    | 10%      |
| De 50 à 1000 itens no estoque  | 12%      |
| Acima de 1000 itens no estoque | 15%      |

**C)** Considere um sistema de fila de espera em que você você deve fornecer uma senha para a pessoa aguardar a sua vez para ser atendida. Crie um programa para classificar se a pessoa será atendida pelo atendimento Comum ou Prioritário. Faça as seguintes perguntas:

    - "Quantos anos você tem?" (ler um número com a idade)
    - "Você é gestante?" (ler sim ou não e converter para `bool`)
    - "Você é PCD?" (ler sim ou não e converter para `bool`)
    
Mostre uma mensagem no Console informando qual é o tipo de atendimento da pessoa, Comum ou Prioritário, baseado nos seguintes critérios: se a pessoa tiver 60 anos ou mais ou for gestante ou PCD, ela deve receber atendimento prioritário. Caso contrário, deve receber atendimento comum.

**D)** Considere um jogo de corrida em que o jogador precisa concluir algumas conquistas para se inscrever no torneio mundial. Ele precisa ter vencido 50 corridas oficiais e derrotado 3 campeões regionais ou ter um bilhete especial que garante sua inscrição instantânea. Crie um programa que pergunte ao usuário quantas corridas oficiais ele venceu, quantos campeões regionais ele derrotou e se ele possui um bilhete especial. Baseado em suas resposta, mostre uma mensagem informando se sua inscrição foi realizada ou não.

#### Desafios

**A)** Crie um programa que calcule o índice de massa corporal (IMC). Primeiro, pergunta à altura do usuário (do tipo `float`), em seguida, pergunte o peso do usuário (Kg, também do tipo `float`). Descubra o IMC calculando o peso divido pela altura ao quadrado. Por exemplo: _peso ÷ altura x altura_.
Em seguida, mostre a classificação do resultado do cálculo do IMC de acordo com os seguintes critérios:

| IMC            | Classificação      |
| -------------- | ------------------ |
| Menor que 18,5 | Abaixo do peso     |
| 18,5 a 24,9    | Peso normal        |
| 25 a 29.9      | Sobrepeso          |
| 30 a 34.9      | Obesidade grau I   |
| 35 a 39,9      | Obesidade grau II  |
| 40 a 49,9      | Obesidade grau III |
| 50 a 59,9      | Obesidade grau IV  |
| Acima de 60    | Obesidade grau V   |

### C# Básico - Loops

- **Vídeo da Aula**: https://youtu.be/UCSqHkfQT80
- **Vídeo de Solução**: https://youtu.be/uly5CasczdA

#### Exercícios

**A)** Crie um programa que calcule a tabuada de um número escolhido pelo usuário. Primeiro, pergunte ao usuário um número para a tabuada e, em seguida, utilize um loop para mostrar a tabuada desse número multiplica pelos valores de 1 a 10.

**B)** Crie um programa em que o usuário deve adivinhar um número de 1 a 10. Em um loop, peça que o usuário digite um número enquanto não escolher o número correto.

**C)** Crie um programa para calcular o valor das parcelas de uma compra. Primeiro, peça que o usuário digite o valor do produto. Em seguida, mostre no console uma projeção dos valores para cada quantidade de parcelas, de 2 a 12.

**D)** Crie um programa para calcular a média das notas de uma turma de 10 alunos. Peça que o usuário informe o nome do aluno e uma nota de 0 a 10 e, no final, mostre uma mensagem com a média das notas dos alunos no Console.

#### Desafios

**A)** Crie um programa que mostre cada letra de um texto de uma variável do tipo `string`, em linhas separadas no Console. Utilize um loop para alcançar esse resultado. Por exemplo, o texto "Unity" deve aparecer da seguinte forma:

```   
U
n
i
t
y
```

**B)** Crie um programa que mostre no Console os número de 1 a 10 em ordem decrescente.

### C# Básico - Classes e Objetos

- **Vídeo da Aula**: https://youtu.be/ij0draC3Oac
- **Vídeo de Solução**: https://youtu.be/BauRNrb2Ols

#### Exercícios

**A)** Crie um programa com que possua uma classe para realizar as seguintes operações matemáticas: soma, subtração, multiplicação e divisão. Para cada operação, deverá ser criado um método que recebe dois números como parâmetros e retorne o valor do resultado. Utilize a classe para calcular os valores informados pelo usuário.

**B)** Considere um jogo de RPG em que o jogador pode criar e personalizar seus personagens. Crie um programa com uma classe que represente um personagem e possua os seguintes atributos:

- Nome (`string`)
- Força (`int`)
- Agilidade (`int`)
- Inteligência (`int`)
    
Além dos atributos anteriores, a classe deve possuir um atributo para armazenar os pontos de vida desse personagem (`int`).

Em seguida, crie um método para cada uma das seguintes ações:

- **Receber Dano:** subtraia a quantidade de pontos de vida por um valor passado como argumento e mostre no Console uma mensagem com quantos pontos de vida o jogador perdeu. Caso os pontos de vida cheguem a 0, mostre uma mensagem no Console informando que o personagem foi derrotado.
- **Imprimir:**  mostre uma mensagem no Console com todos os atributos do personagem.

Ao final, utilize a classe para preencher os atributos informados pelo jogador e utilize os métodos e veja os resultados.

**C)** Formas geométricas:

1. Crie uma classe que represente uma um retângulo. Ela deve possuir altura e largura e os seus valores devem ser definidos assim que o objeto for criado (usando um construtor). Crie métodos para calcular sua área e perímetro.
2. Crie uma classe que represente um círculo. Ela deve possuir um raio e o seu valor deve ser definido assim que o objeto for criado (usando um construtor). Crie métodos para calcular sua área e perímetro.
3. Crie uma classe que represente um triângulo. Ela deve possuir atributos para os três lados, cujo os valores devem ser definidos assim que o objeto for criado (usando um construtor). Crie um método que retorne uma `string` com o tipo de triângulo (equilátero, isósceles ou escaleno) e um método para calcular seu perímetro.

**D)** Crie uma classe que represente uma conta bancária, ela deve ter um saldo inicial e um limite de crédito (definidos no construtor), e um atributo com o valor da sua fatura atual do cartão de crédito. Ambos os atributos não devem ser visíveis para o resto do sistema (modificador de acesso privado). A classe deve possuir os seguintes método:

- **Saque:** recebe um parâmetro com o valor a ser sacado. O valor deve ser subtraído do saldo da conta, porém apenas se o saldo for suficiente para realizar o saque. O método deve retornar o saldo atualizado após o saque ou -1 se o saldo não for suficiente.
- **Depósito:** recebe um argumento com o valor a ser depositado. O valor deve ser adicionado ao saldo da conta e retornar o saldo atualizado após o depósito.
- **Pagar:** realiza um pagamento no cartão de débito ou crédito. Recebe um argumento com a forma de pagamento (débito ou crédito) e um argumento com o valor do pagamento. Caso a forma de pagamento seja débito, o valor deve ser subtraído diretamente do saldo da conta. Caso a forma de pagamento seja crédito, o valor deve ser adicionado à conta do cartão de crédito, porém apenas se ela não exceder o limite de crédito. O método deve retornar um valor do tipo `boolean` que indica se o pagamento foi realizado ou não.
- **Consultar Saldo:** Mostra no Console todos os detalhes da conta bancária, como saldo, limite de crédito e o valor atual da fatura do cartão de crédito.

#### Desafios

**A)** Crie um programa para gerenciar o placar de uma partida entre dois jogadores. Nele, crie uma classe que represente os jogadores, contendo nome e pontuação. Em seguida, crie uma classe que represente o placar, contendo atributos para o `jogador1` e `jogador2` e um atributo com a pontuação necessária para acabar a partida. Ainda na classe do placar, crie um método para adicionar uma pontuação à um dos jogadores, o método deve receber um argumento com o número do jogador (1 ou 2) e quantos pontos ele deve deve ser adicionado e, no fim, mostrar uma mensagem no Console com o placar atual. O método deve retornar um valor indicando que a partida terminou quando um dos jogadores atingir a pontuação máxima.

## Módulo 2

### C# - Propriedades

- **Vídeo da Aula**: https://youtu.be/vYobyPu3WnY
- **Vídeo de Solução**: EM BREVE

#### Exercícios

**A)** Crie uma classe que represente uma pessoa. Ela deve possuir uma propriedade para o primeiro nome e uma propriedade para o sobrenome. Por fim, crie uma terceira propriedade que apresente o nome completo da pessoa.

**B)** Crie uma classe que represente um carrinho de compras de um e-commerce. Ela deve possuir:
    
- Uma propriedade que represente a quantidade de produtos no carrinho. Essa propriedade não pode ser modificada fora classe.
- Uma propriedade que represente o valor total dos produtos no carrinho. Essa propriedade não pode ser modificada fora classe.
- Um método para adicionar um novo produto ao carrinho. Ele deve receber o valor do produto como argumento e será responsável por atualizar o valor das propriedades de quantidade e de valor total
    
Por fim, mostre na tela um resumo do carrinho de compras com o valor total e a quantidade de produtos.

**C)** Crie uma classe que represente uma data. Ela deve possuir propriedades para armazenar dia, mês e ano, todos representados pelo tipo `int`. Por fim, crie uma quarta propriedade para apresentar a data no seguinte formato de texto "dia/mês/ano", por exemplo: "20/04/2025"

- Incremente a classe de data criada no exercício anterior, adicionando uma validação para as propriedades dia e mês.
    1. A propriedade dia só pode aceitar números de 1 até 31
    2. A propriedade mês só pode aceitar números de 1 até 12
- Incremente a classe de data dos exercícios anteriores, adicionando uma nova propriedade que apresente a data por extenso, no seguinte formato "20 de Abril de 2025" (note que o mês é representado pelo nome e não pelo número)

#### Desafios

**A)** Crie uma classe que represente um email. Ela deve possuir as seguintes propriedades com as seguintes regras:

- ***Username***: representa a primeira parte do email (o texto que vem antes do _@_). Ela deve possuir a seguinte validação:
    - Deve possuir 3 caracteres ou mais. Caso o valor informado seja inválido, ele não é atribuído e uma mensagem deve ser informada no Console;
    - Todos os caracteres devem estar em letras minúsculas. Os caracteres com letras maiúsculas no valor informado devem ser transformados para letra minúscula.
- ***Domain:*** representa o endereço do domínio do email. Por exemplo _"gmail.com"_. Deve possuir a seguinte validação:
    - O final do texto deve ser _".com"_, _".com.br"_ ou _".br"_. Caso o domínio não termine com um desses textos, o valor não é atribuído e uma mensagem deve ser informada no Console.
    - A parte antes do ponto (por exemplo, antes do _".com"_) deve possuir pelo menos 3 caracteres. Caso não possua 3 caracteres ou mais, o valor não é atribuído e uma mensagem deve ser apresentada no Console.
- ***Address**:* retorna o endereço de email completo, no seguinte formato: _"<username>@<domain>"_, por exemplo: _"fulanodasilva@email.com"_. Caso as propriedades Username ou Domain não tenham valores, uma mensagem deve ser informada no Console e o valor _"\_invalid_email\_"_ deve ser retornado.

# Exercícios de Projeto

## Módulo 1

### Super Pong

- **Vídeo de Solução**: https://youtu.be/bY96iSpyOXc

#### Exercícios

**A)** Deixe a área do jogo maior aumentando o tamanho da câmera. Garanta que a posição dos _paddles_ seja ajustada de acordo.

**B)** Altere a direção da bola depois que um jogador pontuar fazendo com que ela vá na direção oposta.

**C)** Aumente a velocidade da bola a cada X pontos feitos. Por exemplo, a cada 2 ou 5 pontos, a velocidade da bola aumenta.

#### Desafios

**A)** Defina uma pontuação máxima e reinicie o jogo quando algum jogador vencer.

**B)** Modifique o jogo de modo que a bola comece parada no centro da tela, até que a tecla de espaço seja pressionada. Sempre que algum jogador pontuar, faça com que a bola fique parada novamente no centro por 2 segundos e, após esse tempo, ela inicia o movimento novamente.

**C)** Altere a cor da bola, dos _paddles_ e da câmera sempre que a bola rebater em alguma coisa.
