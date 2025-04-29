namespace Modulo14;

public class TrabalhandoComLinq
{
    public void AulaWhere()
    {
        /*string nomeCompleto = "RAFAEL ALMEIDA";

        Func<char, bool> filtro = c => c == 'A'; /* Filtra as letras 'A' do nome completo. Func � um delegate que representa um m�todo que recebe um par�metro e retorna um valor. Neste caso, o m�todo recebe um char e retorna um bool.
                                                 Pode ser reaproveitado em outros lugares do c�digo, tornando-o mais leg�vel e reutiliz�vel.
                                                 O Func � uma forma de criar m�todos an�nimos, ou seja, m�todos que n�o precisam ser nomeados. 
                                                 Isso � �til quando voc� precisa passar um m�todo como par�metro para outro m�todo, como no caso do Where.
                                                 O Func � uma forma de criar m�todos an�nimos, ou seja, m�todos que n�o precisam ser nomeados. Isso � �til quando voc� precisa passar um m�todo como par�metro para outro m�todo, como no caso do Where. */
        //var resultado = nomeCompleto.Where(filtro);
        //var resultado = nomeCompleto.Where(p => p == 'A'); // Filtra as letras 'A' do nome completo com express�o lambda.
        
        var resultado = from c in nomeCompleto where c == 'E' select c; // Filtra as letras 'E' do nome completo. Sintaxe semelhante ao SQL.

        foreach(var letra in resultado)
        {
            Console.WriteLine(letra);
        }*/

        var numeros = new int[] { 10, 6 , 5, 50, 15, 2};
        var resultado = numeros.Where(p => p >= 10); // Filtra os n�meros maiores ou iguais a 10.
        foreach (var numero in resultado)
        {
            Console.WriteLine(numero);
        }
    }
 
    public void AulaOrdenacao()
    {
        //var numeros = new int[] { 10, 6 , 5, 50, 15, 2};
        var nomes = new string[] { "Rafael", "Eduardo", "Bruno"};
        //var resultado = numeros.OrderByDescending(p => p); // Ordena os n�meros em ordem decrescente.
        var resultado = nomes.OrderBy(p => p); // Ordena os nomes em ordem alfab�tica.

        foreach (var numero in resultado)
        {
            Console.WriteLine(numero);
        }
    }

    public void AulaTake()
    {
        var numeros = new int[] { 10, 6 , 5, 50, 15, 2};
        
        var resultado = numeros.Where(p => p > 10).Take(3).OrderBy(p => p);/ // Filtra os n�meros maiores que 10, pega os 3 primeiros e ordena em ordem crescente.

        foreach (var numero in resultado)
        {
            Console.WriteLine(numero);
        }
    }

    public void AulaCount()
    {
        var numeros = new int[] { 10, 6 , 5, 50, 15, 2};
        
        var resultado = numeros.Count(p => p > 10); // Conta quantos n�meros s�o maiores que 10.

        Console.WriteLine(resultado);
    }
    
    public void AulaFirstEFirstOrDefault()
    {
        var numeros = new int[] { 10, 6 , 5, 50, 15, 2};

        //var resultado = numeros.First(); // Pega o primeiro n�mero do array.
        //var resultado = numeros.First(p => p > 100); // Pega o primeiro n�mero maior que 100. Se n�o encontrar, gera uma exce��o.
        var resultado = numeros.FirstOrDefault(p => p > 100, -99); // Pega o primeiro n�mero maior que 100. Se n�o encontrar, retorna -99.

        Console.WriteLine(resultado);
    }
}