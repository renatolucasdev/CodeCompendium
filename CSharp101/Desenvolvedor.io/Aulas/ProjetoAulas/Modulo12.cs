namespace Modulo12;

public class TrabalhandoComExcecoes
{
    public void AulaGerandoException()
    {
        while(true)
        {
            Console.Write("Informe um numero: ");
            var numero = Console.ReadLine();
            var resultado = 500 / int.Parse(numero); // Gera uma exceção sem tratamento se o usuário digitar 0 ou um valor inválido.
            Console.WriteLine("Resultado: " + resultado);
        }
    }  

    public void AulaTratandoException()
    {
        while(true)
        {   //Tratando exceções, evitando que o programa seja encerrado abruptamente.
            try // Tenta executar o código dentro do bloco try.
            {
                Console.Write("Informe um numero: ");
                var numero = Console.ReadLine();
                var resultado = 500 / int.Parse(numero); // Gera uma exceção se o usuário digitar 0 ou um valor inválido.
                Console.WriteLine("Resultado: " + resultado);
            }
            catch(DivideByZeroException exeception) // Captura a exceção de divisão por zero.
            {
                Console.WriteLine("Ocorreu um erro de divisao: " + exeception.Message);
                Console.WriteLine("Stack: " + exeception.StackTrace);
            }
            catch(Exception exeception)
            {
               Console.WriteLine("Ocorreu um erro: " + exeception.Message);
               Console.WriteLine("Stack: " + exeception.StackTrace);
            }
 
        }
    }  
}