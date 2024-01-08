# Praticando-POO-em-C-sharp

Praticando orientação a objetos em C# com desafios de código da [DIO](https://www.dio.me).

## Desafios de código

- [Primeiro Desafio com POO](#primeiro-desafio-com-poo)
- [Utilizando Propriedades e Métodos](#utilizando-propriedades-e-métodos)
- [Criando um Objeto com Atributos](#criando-um-objeto-com-atributos)
- [Utilizando Construtores](#utilizando-construtores)
- [Utilizando Herança e Subclasses](#utilizando-herança-e-subclasses)

## Primeiro Desafio com POO

Neste desafio, você deve criar uma classe chamada `Pessoa` com dois atributos: `nome` e `idade`. Em seguida, deve implementar dois métodos para obter esses atributos: `getNome()` e `getIdade()`. Por fim, deve criar um objeto do tipo `Pessoa` e exibir na tela o nome e a idade usando os métodos criados.

#### Requisitos:
- Utilizar classes e métodos para implementar o programa;
- Implementar a classe Pessoa com os atributos nome e idade, e o método get para cada atributo;
- O programa deve solicitar que o usuário insira o nome e a idade da pessoa;
- O programa deve exibir o nome e a idade da pessoa inserida pelo usuário.

### Entrada
A entrada deverá receber as informações do objeto Pessoa, conforme exemplo abaixo:
- `nome (string)`
- `idade (int)`

### Saída
O código deverá retornar uma mensagem (string) informando o nome e idade da pessoa, de acordo com o que foi recebido como entrada. Veja como exemplo a entrada recebida abaixo:

  - `joão`
  - `26`

### Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

| Entrada      | Saída        |
| -----------  | -----------  |
| Ana <br> 17  | Nome: Ana, Idade: 17   |
| Paulo <br> 44    | Nome: Paulo, Idade: 44 |
| Maria <br> 32    | Nome: Maria, Idade: 32 |
  
## Utilizando Propriedades e Métodos

Você foi contratado para criar um software que simule o controle de velocidade de um robô. Esse robô possui uma velocidade máxima e uma velocidade mínima. Sua tarefa é desenvolver um programa  utilizando o conceito de Orientação a Objetos para calcular a velocidade final do robô após uma sequência de comandos.Crie uma classe chamada "Robo" que possua as seguintes propriedades e métodos:

`velocidadeAtual`: inteiro que representa a velocidade atual do robô (inicialmente 0);

`velocidadeMaxima`: inteiro que representa a velocidade máxima do robô;

`velocidadeMinima`: inteiro que representa a velocidade mínima do robô;

`acelerar()`: um método que aumenta a velocidade atual em 1 unidade, desde que não ultrapasse a velocidade máxima;

`desacelerar()`: um método que diminui a velocidade atual em 1 unidade, desde que não fique abaixo da velocidade mínima.

### Entrada

A entrada consiste em duas linhas: A primeira linha contém dois inteiros Vmin e Vmax (1 ≤ Vmin < Vmax ≤ 100), representando a velocidade mínima e máxima do robô, respectivamente.
A segunda linha contém uma sequência de comandos (com no máximo 100 caracteres), onde: 'A' representa uma aceleração e 'D' representa uma desaceleração. Desta maneira, a entrada seria da seguinte maneira:

 - `Vmin Vmax`: ambos valores int.
 - `comandos`: string.

### Saída

A saída deve apresentar apenas a velocidade final (int)  do robô, considerando as regras descritas nos métodos de acelerar e desacelerar.

### Exemplos

A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

| Entrada      | Saída        |
| -----------  | -----------  |
| 1 5 <br> AADAD  |     2     |
| 2 8 <br> ADAAD    |   3     |

## Criando um Objeto com Atributos

Você deve criar um programa que crie um objeto jogador com nome, nacionalidade, idade e posição. O jogador deve ser criado a partir de uma classe "Jogador" com o método "novo" e os atributos mencionados.

### Entrada

O programa deve ler as informações do jogador nessa ordem: 
 - `nome`: string
 - `nacionalidade`: string
 - `idade`: inteiro
 - `posição`: strig

### Saída

O programa deve imprimir as informações do jogador criado, uma por linha, com a mensagem "Jogador criado!" no início. As informações devem ser exibidas na seguinte ordem: nome, nacionalidade, idade e posição (com a mensagem "Posição:" na frente). Veja a estrutura abaixo:

`Jogador criado!`<br>
`[nome]`<br>
`[nacionalidade]`<br>
`[idade]`<br>
`Posição: [posição]`

### Exemplos

A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

| Entrada      | Saída        |
| -----------  | -----------  |
| Ronaldo <br> Brasil <br> 46 <br> Atacante  | Jogador criado! <br> Ronaldo <br> Brasil <br> 46 <br>  Posição: Atacante |
| Puyol <br> Espanha <br> 20 <br> Zagueiro  | Jogador criado! <br> Puyol <br> Espanha <br> 20 <br>  Posição: Zagueiro |
| John <br> EUA <br> 28 <br> Meio-campo  | Jogador criado! <br> John <br> EUA <br> 28 <br>  Posição: Meio-campo |

## Utilizando Construtores

No mundo dos RPGs, a criação do personagem é um momento importante e emocionante para os jogadores! Durante esse processo, o jogador deve escolher o nome, a raça, a classe e outras características importantes para o personagem.

Crie uma classe chamada `Personagem` que tenha os seguintes atributos: `nome (string)`, `raça (string)`, `classe (string)`, `nível (inteiro)`, `vida (inteiro)` e `mana (inteiro)`. A classe deve ter um construtor que recebe como parâmetros o nome, a raça e a classe do personagem. O nível e a vida devem ser iniciados com valores padrão (1 e 10 , respectivamente). Além disso, crie um método chamado `exibir_status` que exibe na tela o nome, a raça, a classe, o nível, a vida e a mana do personagem.

### Entrada

A entrada deve conter as informações necessárias para a criação do personagem, como nome, raça e classe.

### Saída

A saída deve conter a frase "Status:" seguida das informações do método `exibir_status`, ou seja, deve exibir na tela o `nome`, a `raça`, a `classe`, o `nível` e a `vida` do personagem. Conforme exemplos abaixo.

### Exemplos

A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

| Entrada      | Saída        |
| -----------  | -----------  |
| bjorn <br> anão <br> guerreiro | Status: <br> Nome:bjorn <br>  Raça:anão <br>  Classe:guerreiro <br>  Nível:1 <br>  Vida:10 |
| veniCaçador <br> elfo <br> mago | Status: <br> Nome:veniCaçador <br>  Raça:elfo <br>  Classe:mago <br>  Nível:1 <br>  Vida:10 |
| sorth <br> goblin <br> paladino | Status: <br> Nome:sorth <br>  Raça:goblin <br>  Classe:paladino <br>  Nível:1 <br>  Vida:10 |

## Utilizando Herança e Subclasses

Em jogos de RPG, os personagens frequentemente possuem subclasses que representam especializações em determinadas áreas de combate, como por exemplo, "mago", "guerreiro", "ladino", etc. Neste desafio, você deve criar duas classes, `Personagem` e `Subclasse`, que ilustrem o conceito de herança em POO.

Crie a classe `Personagem` que possua o atributo `nome` e `mana`.

Crie a classe `Subclasse` que herda de `Personagem` e acrescenta o atributo `dano_base` e o método `calcular_dano`, que recebe como argumento a quantidade de mana que será usada no ataque e retorna o dano causado pelo ataque, que é calculado como o valor de `dano_base` multiplicado pela quantidade de mana usada.

### Entrada

A entrada será dada pela chamada da classe `Subclasse` e seus métodos, para obter os valores dos atributos de cada personagem e a quantidade de mana usada no ataque. Os valores a serem recebidos serão:

 - `nome`: nome do personagem
 - `mana`: quantidade de mana do personagem
 - `dano base`: referente ao dano base da subclasse

 <b>Importante</b>: a entrada deverá ocorrer de acordo com a ordem das informações fornecidas acima.

### Saída

A saída deverá ser a impressão da mensagem "Nome do personagem atacou e causou X de dano!", onde "Nome do personagem" é o nome do personagem fornecido na entrada e "X" é o valor de dano calculado pela subclasse a partir da quantidade de mana usada no ataque. Conforme exemplos abaixo.

### Exemplos

A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

| Entrada      | Saída        |
| -----------  | -----------  |
| sauron <br> 30 <br> 30 | sauron atacou e causou 900 de dano! |
| frodo <br> 10 <br> 5 | frodo atacou e causou 50 de dano! |
| legolas <br> 23 <br> 20 | legolas atacou e causou 460 de dano! |
