# Ficha de Programação e Sistemas de Informação - Classes

Faz *fork* do repositório para teres a tua cópia.
Faz clone da tua cópia do repositório para o teu PC.
Preenche o README localmente e seguidamente faz push das atualizações.

Escreve as respostas dentro dos blocos correspondentes. Substitui as reticências pelo que é pedido em cada pergunta. Não desformates o documento.

## Informação do aluno

    Nome: Filipe Alberto

## E1 - Responde às seguintes questões (4v)

    1 - As classes são tipos de referência? 
            Variaveis, Métodos, Construtores, Propriedades.
    2 - (Classes) definem o que algo pode fazer e guardar, enquanto uma
        (instância) é um objeto específico que contém o seu próprio estado 
        (Apaga a opção entre parênteses errada)
    3 - Indica três tipos de membros que podem pertencer a uma classe 
            Atributos, Métodos, Membros Estáticos.
    4 - Se algo é static então é partilhado por todas as instâncias desse tipo específico? 
            Sim. Quando um membro de uma classe é declarado como static, ele é compartilhado por todas as instâncias dessa classe em vez de ser associado a uma instância específica
    5 - Como se chamam os métodos especiais que inicializam uma classe? 
        ...
    6 - De onde podes aceder a algo private? 
            privates são acessíveis apenas dentro da própria classe onde foram declarados
    7 - De onde podes aceder a algo public? 
            São acessíveis de qualquer lugar no código, tanto dentro da mesma classe quanto em outras classes e até mesmo em assemblies diferentes, desde que a classe seja acessível.
    8 - De onde podes aceder a algo internal? 
            São acessíveis apenas dentro do mesmo assembly.
            ele pode ser acessado por qualquer código dentro do mesmo assembly, mas não pode ser acessado por código de fora desse assembly

## E2 - Explica por palavras tuas o significado dos seguintes termos (4v)

    1 - Classe
            Em programação orientada a objetos, uma classe é uma estrutura que define um tipo de objeto. 
    2 - Objeto / instância
            Um objeto é uma instância específica de uma classe.
    3 - Método
            Um método em programação é uma coleção de instruções ou comandos que realizam uma tarefa específica.
    4 - Construtor
            Um construtor em programação é um método especial dentro de uma classe que é chamado automaticamente quando um objeto da classe é criado
    5 - Variável de instância
            Uma variável de instância, em programação orientada a objetos, é uma variável que pertence a uma instância específica de uma classe.
    6 - Variável local
            Uma variável local em programação é uma variável declarada dentro de um bloco de código, método, função ou construtor e que só é acessível dentro desse escopo específico.
    7 - Overloading
            O overloading, ou sobrecarga de método, é um conceito em programação que permite que uma classe tenha dois ou mais métodos com o mesmo nome, mas com diferentes listas de parâmetros.
    8 - Encapsulação
            Encapsulação é um princípio fundamental da programação orientada a objetos que se refere ao empacotamento de dados e os métodos que operam nesses dados em uma única unidade, chamada de classe

## E3 - Cria o seguinte programa de consola (12v)

- Nome do projeto: **BolasColoridas**
  - Cria a classe **Cor** com:
    - Estado representado pelos valores **red, green, blue, alpha**
    - Construtor que aceita todos os parâmetros necessários para inicializar o estado de uma cor
    - Construtor que aceita **red, green, blue,** e coloca **alpha** a 255
    - Métodos *getter* e *setter* para os componentes **red, green, blue e alpha**
    - Método *getter* para obter o grau de cinzento da cor, igual à média dos valores **red, green e blue**
  - Cria a classe **Bola** com:
    - Estado representado pelos valores de **cor, raio e o nº de vezes que a bola foi atirada**
    - Construtores apropriados
    - Método **Pop()** que fura a bola (coloca o seu raio a zero)
    - Método **Atirar()** que incrementa o nº de vezes que a bola foi atirada (apenas se a bola não estiver furada)
    - Método que retorna o nº de vezes que a bola foi atirada
  - Na classe **Program**, método **Main**, escreve código para:
    - Criar algumas bolas
    - Atirar as bolas várias vezes
    - Rebentar algumas das bolas
    - Imprimir no ecrã o estado de cada uma (incluindo cor)
  - Faz vários *commits* ao longo do desenvolvimento e no fim faz *push* para o repositório remoto
