namespace Modulo14;

public class TrabalhandoComLinq
{
    public void AulaWhere()
    {
        /*string nomeCompleto = "RAFAEL ALMEIDA";

        Func<char, bool> filtro = c => c == 'A'; /* Filtra as letras 'A' do nome completo. Func é um delegate que representa um método que recebe um parâmetro e retorna um valor. Neste caso, o método recebe um char e retorna um bool.
                                                 Pode ser reaproveitado em outros lugares do código, tornando-o mais legível e reutilizável.
                                                 O Func é uma forma de criar métodos anônimos, ou seja, métodos que não precisam ser nomeados. 
                                                 Isso é útil quando você precisa passar um método como parâmetro para outro método, como no caso do Where.
                                                 O Func é uma forma de criar métodos anônimos, ou seja, métodos que não precisam ser nomeados. Isso é útil quando você precisa passar um método como parâmetro para outro método, como no caso do Where. */
        //var resultado = nomeCompleto.Where(filtro);
        //var resultado = nomeCompleto.Where(p => p == 'A'); // Filtra as letras 'A' do nome completo com expressão lambda.
        
        var resultado = from c in nomeCompleto where c == 'E' select c; // Filtra as letras 'E' do nome completo. Sintaxe semelhante ao SQL.

        foreach(var letra in resultado)
        {
            Console.WriteLine(letra);
        }*/

        var numeros = new int[] { 10, 6 , 5, 50, 15, 2};
        var resultado = numeros.Where(p => p >= 10); // Filtra os números maiores ou iguais a 10.
        foreach (var numero in resultado)
        {
            Console.WriteLine(numero);
        }
    }
 
    public void AulaOrdenacao()
    {
        //var numeros = new int[] { 10, 6 , 5, 50, 15, 2};
        var nomes = new string[] { "Rafael", "Eduardo", "Bruno"};
        //var resultado = numeros.OrderByDescending(p => p); // Ordena os números em ordem decrescente.
        var resultado = nomes.OrderBy(p => p); // Ordena os nomes em ordem alfabética.

        foreach (var numero in resultado)
        {
            Console.WriteLine(numero);
        }
    }

    public void AulaTake()
    {
        var numeros = new int[] { 10, 6 , 5, 50, 15, 2};
        
        var resultado = numeros.Where(p => p > 10).Take(3).OrderBy(p => p);/ // Filtra os números maiores que 10, pega os 3 primeiros e ordena em ordem crescente.

        foreach (var numero in resultado)
        {
            Console.WriteLine(numero);
        }
    }

    public void AulaCount()
    {
        var numeros = new int[] { 10, 6 , 5, 50, 15, 2};
        
        var resultado = numeros.Count(p => p > 10); // Conta quantos números são maiores que 10.

        Console.WriteLine(resultado);
    }
    
    public void AulaFirstEFirstOrDefault()
    {
        var numeros = new int[] { 10, 6 , 5, 50, 15, 2};

        //var resultado = numeros.First(); // Pega o primeiro número do array.
        //var resultado = numeros.First(p => p > 100); // Pega o primeiro número maior que 100. Se não encontrar, gera uma exceção.
        var resultado = numeros.FirstOrDefault(p => p > 100, -99); // Pega o primeiro número maior que 100. Se não encontrar, retorna -99.

        Console.WriteLine(resultado);
    }
}