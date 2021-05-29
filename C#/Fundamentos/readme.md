# Fundamentos
- [Fundamentos](#fundamentos)
  - [Exemplo Básico](#exemplo-básico)
    - [Console.writeLine](#consolewriteline)
    - [Método Main](#método-main)
    - [Class e namespace](#class-e-namespace)


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