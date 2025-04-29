namespace Conversores;

public class Conversor
{
    public void ConvertAndParse()
    {
        //int numero = int.Parse("1"); //convertendo string para inteiro.
        //int numero = Convert.ToInt32(null); //convertendo string para inteiro. Pode converter null para 0.
        //É uma boa prática utilizar o Parse ao invés do Convert, pois o Parse lança uma exceção caso não consiga converter.
        //int numero = int.Parse(null);
        bool verdadeiro = bool.Parse("true");
        Console.WriteLine(verdadeiro);
    }

    public void AulaTryParse()
    {
        //var numero = "123456";
        var numero = "abc";//string que não pode ser convertida para inteiro. Atribui o valor defaulto 0 para a variável numeroConvertido, e não lança exceção.

        int numeroConvertido;
                               //int out numeroConvertido também pode ser utilizado no segundo parâmetro.
        if (int.TryParse(numero, out numeroConvertido)) //primeiro parâmetro é a string que queremos converter, segundo parâmetro é o valor convertido. O TryParrse pode ser utilizado com todos os tipos primitivos.
        {
            Console.WriteLine("Numero foi convertido com sucesso!");
        }

        Console.WriteLine(numeroConvertido);
    }
}