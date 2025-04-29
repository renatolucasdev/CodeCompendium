namespace Conversores;

public class Conversor
{
    public void ConvertAndParse()
    {
        //int numero = int.Parse("1"); //convertendo string para inteiro.
        //int numero = Convert.ToInt32(null); //convertendo string para inteiro. Pode converter null para 0.
        //� uma boa pr�tica utilizar o Parse ao inv�s do Convert, pois o Parse lan�a uma exce��o caso n�o consiga converter.
        //int numero = int.Parse(null);
        bool verdadeiro = bool.Parse("true");
        Console.WriteLine(verdadeiro);
    }

    public void AulaTryParse()
    {
        //var numero = "123456";
        var numero = "abc";//string que n�o pode ser convertida para inteiro. Atribui o valor defaulto 0 para a vari�vel numeroConvertido, e n�o lan�a exce��o.

        int numeroConvertido;
                               //int out numeroConvertido tamb�m pode ser utilizado no segundo par�metro.
        if (int.TryParse(numero, out numeroConvertido)) //primeiro par�metro � a string que queremos converter, segundo par�metro � o valor convertido. O TryParrse pode ser utilizado com todos os tipos primitivos.
        {
            Console.WriteLine("Numero foi convertido com sucesso!");
        }

        Console.WriteLine(numeroConvertido);
    }
}