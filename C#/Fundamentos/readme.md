# Fundamentos
- [Fundamentos](#fundamentos)
  - [Exemplo Básico](#exemplo-básico)
    - [Console.writeLine](#consolewriteline)
    - [Método Main](#método-main)
    - [Class e namespace](#class-e-namespace)
  - [Tipos](#tipos)
    - [Booleano e inferência de tipos](#booleano-e-inferência-de-tipos)
      - [Interpolando valores](#interpolando-valores)
    - [Strings](#strings)


## Exemplo Básico

    using System;   

    namespace Fundamentos
    {
        class Class1
        {
            static void Main()
            {
                System.Console.WriteLine("Exemplo Básico");
            }
        }
    }

### Console.writeLine
Nesse código acima, temos uma estrutura básica de como deve ser um código no `C#`, não difere muito do Java, porém existe diferenças, usando o comando `using` ocorre a importação de bibliotecas, conforme visto aqui `using System;`, no entanto ela não está sendo usada, porém graças a essa importação, essa linha `System.Console.WriteLine("Exemplo Básico");`, poderia tranquilamente se transformar em `Console.WriteLine("Exemplo Básico");`, uma vez que o `System` foi importado usando o `using`. Além disso o método `Write` do Objeto Console não faz a quebra de linha.

### Método Main
O `C#` tem um método `Main` que serve como entrada, da mesma forma com que ocorre `main` no Java, porém a assinatura desse método não é fixo, podendo ou não aceitar argumentos, ou seja, pode ser `Main()`, ou `Main(String[] args)`, de resto se assemelha ao Java, o `void` indica sem retorno, o `static`, que o método é estático e como o public está omitido, logo a visibilidade desse método não é pública.

### Class e namespace
Namespace no `C#`,funciona de maneira semelhante ao PHP, ou seja é apenas uma organização lógica, sendo perfeitamente possível, o mesmo distoar da hierarquia de pastas sem grandes problemas, as classes também tem visibilidade aqui igual no Java e no PHP.

## Tipos
O `C#` é uma linguagem de programação fortemente tipada, porém em alguns casos o C# Consegue inferir o tipo da variável ou atributo.
### Booleano e inferência de tipos
[Código Exemplo](Booleanos.cs)

    using System;
    namespace Fundamentos
    {
        class Tipos
        {
            public static void Executar()
            {
                const bool booleano = true;
                var inferida = false;

                //Booleanos
                Console.WriteLine("Primeiro booleano: "+booleano+", Segundo booleano: "+inferida);               
            }
        }
    }

O `const` na frente da variável ou atributo indica que é uma constante, conforme visto aqui `const bool booleano = true;`, além disso logo na linha abaixo temos esse código `var inferida = false;`, nesse `var` nós não definimos um tipo, isso será definido pelo `C#`, que irá escolher a melhor estrutura para esse dado, no entanto uma vez que a estrutura seja escolhida, o dado deve seguir a estrutura, uma vez que a linguagem é fortemente tipificada. Nesse caso `var inferida = false;`, será escolhido o tipo booleano, e caso você queira colocar um número inteiro ou String ali dentro, será lançado um erro, pois uma vez que o `C#` define um tipo, o dado deve respeitar a estrutura, nesse caso `var inferida = false;` o `C#` vai definir o tipo como booleano e uma vez feito isso, ou seja uma vez definido a estrutura, a mesma deve ser respeitada, logo não confundir o `var` do `C#` com o do javascript.

#### Interpolando valores
    Console.WriteLine("Primeiro booleano: "+booleano+", Segundo booleano: "+inferida);

Nesse código acima é possível interpolar valores, como há uma concatenação `"+booleano+"` e `"+inferida`, nesse caso devido a concatenação, tudo será tratado como uma String. Repare também que o `Console` foi omitido, e isso corre devido a essa importação `using System;`

### Strings
[Textos](Textos.cs)

    using System;
    namespace Fundamentos
    {
        class Textos
        {
            public static void Executar()
            {
                //Char
                char letra = 'a';
                Console.WriteLine(letra);

                //String
                string texto = "TEXTO - 1";
                Console.WriteLine(texto);

                //Interpolando em sequencia
                Console.WriteLine("Valor 1: {0}, valor 2: {1}, valor 3: {2}, etc...",1,2,3);

                //Interpolando com variaveis.
                Console.WriteLine($"Valor da variável texto = {texto}");
            }
        }
    }

O *Char* funciona para um caracter em específico, identico a forma de funcionamento do java o mesmo ocorre com os valores do tipo String. Porém o `Console.WriteLine` funciona de maneira um pouco diferente do `System.out.println`, por exemplo, aqui temos a exibição de variáveis em sequência `Console.WriteLine("Valor 1: {0}, valor 2: {1}, valor 3: {2}, etc...",1,2,3);`, nesse exemplo `{0}`, pega o primeiro valor após a vírgula, `{1}` o segundo e por ai vai... Além disso o método aceita template string, conforme nesse exemplo `Console.WriteLine($"Valor da variável texto = {texto}");`, nesse caso o cifrão na frente das aspas, indica que todo o valor entre as chaves deve ser interpolada.