# Fundamentos
[Documentação .NET](https://docs.microsoft.com/pt-br/)

[Documentação C#](https://docs.microsoft.com/pt-br/dotnet/csharp/)
- [Fundamentos](#fundamentos)
  - [Exemplo Básico](#exemplo-básico)
    - [Console.writeLine](#consolewriteline)
    - [Método Main](#método-main)
    - [Class e namespace](#class-e-namespace)
  - [Tipos](#tipos)
    - [Booleano e inferência de tipos](#booleano-e-inferência-de-tipos)
      - [Interpolando valores](#interpolando-valores)
    - [Strings](#strings)
    - [Números](#números)
      - [Exemplo com dados numéricos](#exemplo-com-dados-numéricos)
      - [Organizando as casas decimais.](#organizando-as-casas-decimais)
    - [Entrada de dados](#entrada-de-dados)
    - [Cast](#cast)
    - [Entrada de dados](#entrada-de-dados-1)
    - [Culture Info](#culture-info)
      - [CultureInfo](#cultureinfo)
      - [InvariantCulture](#invariantculture)
      - [Convert](#convert)
          - [output do código acima](#output-do-código-acima)


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
O `C#` é uma linguagem de programação fortemente tipada, porém em alguns casos o C# Consegue inferir o tipo da variável ou atributo. [Documentação sobre tipos](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/value-types)
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

O `const` na frente da variável ou atributo indica que é uma constante, conforme visto aqui `const bool booleano = true;`, além disso logo na linha abaixo temos esse código `var inferida = false;`, nesse `var` nós não definimos um tipo, isso será definido pelo `C#`, que irá escolher a melhor estrutura para esse dado, no entanto uma vez que a estrutura seja escolhida, o dado deve seguir a estrutura, uma vez que a linguagem é fortemente tipificada. Nesse caso `var inferida = false;`, será escolhido o tipo booleano, e caso você queira colocar um número inteiro ou String ali dentro, será lançado um erro, pois uma vez que o `C#` define um tipo, o dado deve respeitar a estrutura, nesse caso `var inferida = false;` o `C#` vai definir o tipo como booleano e uma vez feito isso, ou seja uma vez definido a estrutura, a mesma deve ser respeitada, logo não confundir o `var` do `C#` com o do javascript. [Documentação booleanos](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/bool)

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

### Números
1. [Documentação Números Inteiros](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/integral-numeric-types)
2. [Documentação Números Flutuantes](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types)
3. [nint e nuint](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/nint-nuint)
4. [Conversões de tipos](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/numeric-conversions)

<table border="1px">
    <thead style="background:black;color:white;">
        <th>Tipo de dados</th>
        <th>Intervalo</th>
        <th>Sinal</th>
        <th>Tipo</th>
        <th>Tamanho</th>
    </thead>
    <tbody>
        <tr><th>byte</th><th>0 ..255</th><th>Não</th><th>Inteiro</th><th>1 Byte</th></tr>
        <tr><th>sbyte</th>	<th>-128 ..127</th><th>Sim</th><th>Inteiro</th><th>1 Byte</th></tr>
        <tr><th>short</th>	<th>-32,768 ..32,767</th><th>Sim</th><th>Inteiro</th><th>2 Bytes</th></tr>
        <tr><th>ushort</th>	<th>0 ..65,535</th><th>Não</th><th>Inteiro</th><th>2 Bytes</th></tr>
        <tr><th>int</th>	    <th>-2,147,483,648 ..2,147,483,647</th><th>Sim</th><th>Inteiro</th><th>4 Bytes</th></tr>
        <tr><th>uint</th>	<th>0 ..4,294,967,295</th><th>Não</th><th>Inteiro</th><th>4 Bytes</th></tr>
        <tr><th>long</th>	<th>-9,223,372,036,854,775,808..9,223,372,036,854,775,807</th><th>Sim</th><th>Inteiro</th><th>8 Bytes</th></tr>
        <tr><th>ulong</th>	<th>0 ..18,446,744,073,709,551,615</th><th>Não</th><th>Inteiro</th><th>8 Bytes</th></tr>
        <tr><th>float</th>	<th>-3.402823e38 ..3.402823e38</th><th>Sim</th><th>Decimal</th><th>4 Bytes</th></tr>
        <tr><th>double</th>	<th>-1.79769313486232e308 ..1.79769313486232e308</th><th>Sim</th><th>Decimal</th><th>8 Bytes</th></tr>
        <tr><th>decimal</th>	<th>-79228162514264337593543950335..79228162514264337593543950335</th><th>Sim</th><th>Decimal</th><th>16 Bytes</th></tr>        
    </tbody>    
</table>

#### Exemplo com dados numéricos
[Numeros](Numeros.cs)

    using System;
    namespace Fundamentos
    {
        class Numeros
        {
            public static void Executar()
            {
                int numero = 0;
                Console.WriteLine(numero);

                //Byte
                Console.WriteLine($"Byte, Valor Mínimo: {byte.MinValue}, valor Máximo {byte.MaxValue}");

                //Signal Byte
                Console.WriteLine($"SByte, Valor Mínimo: {sbyte.MinValue}, valor Máximo {sbyte.MaxValue}");

                //Short
                Console.WriteLine($"Short, valor mínimo: {short.MinValue}, valor máximo: {short.MaxValue}");

                //Int
                Console.WriteLine($"Integer, valor mínimo: {int.MinValue}, valor máximo: {int.MaxValue}");

                //Uint
                Console.WriteLine($"Uint, valor mínimo: {uint.MinValue}, valor máximo: {uint.MaxValue}");

                //Long
                Console.WriteLine($"Long, valor mínimo: {long.MinValue}, valor máximo {long.MaxValue}");

                //ULong
                Console.WriteLine($"ULong, valor mínimo: {ulong.MinValue}, valor máximo {ulong.MaxValue}");

                //Float
                Console.WriteLine($"Float, valor mínimo: {float.MinValue}, valor máximo {float.MaxValue}");

                //Double
                Console.WriteLine($"Double, valor mínimo: {double.MinValue}, valor máximo {double.MaxValue}");

                //Decimal
                Console.WriteLine($"Decimal, valor mínimo: {decimal.MinValue}, valor máximo {decimal.MaxValue}");

                //organizando numeros
                int num = 1_000_000;
                Console.Write("Exibindo o número: ");
                Console.WriteLine(num);
            }
        }
    }

**Todos os tipos destinados a valores numéricos tem métodos e atributos, nesse caso através do `.MinValue` você consegue pegar o menor valor daquele tipo de dados, ao passo que `.MaxValue` pega o maior.**

>A partir do C# 9,0, você pode usar `nint` as `nuint` palavras-chave e para definir inteiros de tamanho nativo. Esses são inteiros de 32 bits ao serem executados em um processo de 32 bits ou inteiros de 64 bits ao serem executados em um processo de 64 bits. Eles podem ser usados para cenários de interoperabilidade, bibliotecas de nível baixo e para otimizar o desempenho em cenários em que o inteiro de matemática é usado extensivamente.

#### Organizando as casas decimais.

     //organizando numeros
        int num = 1_000_000;
        Console.Write("Exibindo o número: ");
        Console.WriteLine(num);

Você pode usar o underline como separador da casa de milhar, conforme visto aqui `int num = 1_000_000;`.

### Entrada de dados

    using System;
    namespace Fundamentos
    {
        class Conversao
        {
            public static void Executar()
            {
                Console.WriteLine("Digite alguma coisa:");
                string resultado = Console.ReadLine();
                Console.WriteLine("Texto digitado:"+resultado);   

                ...             
            }
        }
    }

Você pode usar o método `Console.ReadLine();`, para receber dados do usuário, valido lembrar que o método `ReadLine` retorna uma String, se tiver esperando um outro dado, se faz necessário converter o mesmo.

### Cast
[Conversão](Conversao.cs)

    using System;
    namespace Fundamentos
    {
        class Conversao
        {
            public static void Executar()
            {
                ...

                Console.WriteLine("Dando cast no valor 10.3 para inteiro: {0}",((int) 10.3));
                Console.WriteLine(
                        "Convertendo texto para numero: Com Ponto para decimal: '{0}', com virgula: '{1}'",
                            double.Parse("22.657"), 
                            double.Parse("22,657")
                );
            }
        }
    }

Você pode fazer cast no C# igual no Java `... (int) 10.3 ...`, se não houver perda de dados o `cast` ocorre de uma maneira implicita, porém quando ocorre a possibilidade de perdas, como quando ocorre nesse caso `(int) 10.3)`, aonde ao dar um cast com `(int)` em um número decimal, perde-se a parte fracionário, se faz necessário deixar o `cast` explícito. Outra coisa a ser observado é justamente a formatação de dados.

### Entrada de dados
[Conversão](Conversao.cs)

     Console.WriteLine(
        "Convertendo texto para numero: Com Ponto para decimal: '{0}', com virgula: '{1}'",
        double.Parse("22.657"), 
        double.Parse("22,657")
    );

Aqui podemos ver um exemplo de como funciona a entrada de dados no `C#`. Essa linguagem de programação leva em consideração a formatação do sistema operacional, por exemplo, em um computador, cuja o sistema operacional entende o separador de casas decimais seja o ponto, essa conversão para double tende a retornar um número decimal `double.Parse("22.657")` porém esse não `double.Parse("22,657")`, agora se o sistema operacional entender a vírgula como um separador para casa decimais, a situação se inverte, como **nesse computador** tem como caracter separador de casa decimais **a vírgula**, logo essa deva-se usar como o separador de casa decimal, sendo **o ponto entendido como separador de milhar**, logo isso deve ser levado em consideração, e esse fenômeno não ocorre apenas com o separador de vírgula, mas com datas, separador de milhar, etc... Caso essa característica não seja desejável, se faz necessário informar isso na sentença de código. Para isso temos o `Globalization`.

### Culture Info
[Culture](ExemploCulture.cs)

    using System;
    using System.Globalization;

    namespace Fundamentos
    {
        class ExemploCulture
        {
            public static void Executar()
            {
                CultureInfo americano = new CultureInfo("en-US");
                double numeroAmericano = Convert.ToDouble("10.25",americano);

                CultureInfo brasileiro = new CultureInfo("pt-BR");
                double numeroBrasileiro = Convert.ToDouble("10,25", brasileiro);

                Console.WriteLine($"Numero americano convertido: {numeroAmericano} Brasileiro convertido: {numeroBrasileiro} os valores são iguais? {numeroAmericano == numeroBrasileiro}");

                double numeroPadrao = Convert.ToDouble("10.25", CultureInfo.InvariantCulture);
                Console.WriteLine("Numero Padrao: "+numeroPadrao);         
            }
        }
    }

#### CultureInfo
Com o `CultureInfo` você consegue contornar esse problema, aqui `CultureInfo americano = new CultureInfo("en-US");` ou aqui `CultureInfo brasileiro = new CultureInfo("pt-BR");`, nesse caso a a formatação de data, e formatações do sistema operacional será ignorado e levado essa instancia, caso o mesmo seja passado como parametros, conforme ilustrado aqui `double numeroAmericano = Convert.ToDouble("10.25",americano);` e aqui `double numeroBrasileiro = Convert.ToDouble("10,25", brasileiro)`, no caso, nessa conversão que além de ser mais segura, está sendo levado a cultura passado como parametro no segundo argumento, ao invés do padrão que é o sistema operacional, caso esse argumento seja omitido. O `CultureInfo` exige a um argumento passado como `string` contendo uma abreviação do idioma em mínusculo, traço o país em questão, ambos abreviado, conforme visto em: `("en-US")`, `("pt-BR")`. [Documentação CultureInfo](https://docs.microsoft.com/pt-br/dotnet/api/system.globalization.cultureinfo?view=net-5.0)

#### InvariantCulture
Passando esse objeto como argumento `CultureInfo.InvariantCulture`, você estipula como cultura padrão o padrão da linguagem `C#`, que é o padrão americano.
#### Convert
O convert permite fazer conversões de maneiras mais seguras que um simples cast. [Documentação Convert](https://docs.microsoft.com/pt-br/dotnet/api/system.convert?view=net-5.0)
###### output do código acima
    Numero americano convertido: 10,25 Brasileiro convertido: 10,25 os valores são iguais? True

