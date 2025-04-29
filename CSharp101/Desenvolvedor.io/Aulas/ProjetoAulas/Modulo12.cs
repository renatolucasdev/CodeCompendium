namespace Modulo12;

public class TrabalhandoComExcecoes
{
    public void AulaGerandoException()
    {
        while(true)
        {
            Console.Write("Informe um numero: ");
            var numero = Console.ReadLine();
            var resultado = 500 / int.Parse(numero); // Gera uma exce��o sem tratamento se o usu�rio digitar 0 ou um valor inv�lido.
            Console.WriteLine("Resultado: " + resultado);
        }
    }  

    public void AulaTratandoException()
    {
        while(true)
        {   //Tratando exce��es, evitando que o programa seja encerrado abruptamente.
            try // Tenta executar o c�digo dentro do bloco try.
            {
                Console.Write("Informe um numero: ");
                var numero = Console.ReadLine();
                var resultado = 500 / int.Parse(numero); // Gera uma exce��o se o usu�rio digitar 0 ou um valor inv�lido.
                Console.WriteLine("Resultado: " + resultado);
            }
            catch(DivideByZeroException exeception) // Captura a exce��o de divis�o por zero.
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