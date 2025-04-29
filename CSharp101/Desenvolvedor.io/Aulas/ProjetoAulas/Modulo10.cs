namespace Modulo10;

public class TrabalhandoComStrings
{
    public void ConverterParaLetrasMinusculas()
    {
        Console.Write("Favor digitar alguma informacao: ");
        var linha = Console.ReadLine(); // L� uma linha de texto do console.
        Console.WriteLine(linha.ToLower());// Converte a string para letras min�sculas. �til para normalizar entradas de texto.
    }

    public void ConverterParaLetrasMaiusculas()
    {
        Console.Write("Favor digitar alguma informacao: ");
        var linha = Console.ReadLine();
        Console.WriteLine(linha.ToUpper());// Converte a string para letras mai�sculas. �til para normalizar entradas de texto.
    }

     public void AulaSubstring()
    {
        Console.Write("Favor digitar alguma informacao: ");
        var linha = Console.ReadLine();
        Console.WriteLine(linha.Substring(6));// Substring � um m�todo que retorna uma parte da string original, come�ando do �ndice especificado at� o final da string.
    }                                         //Possui 2 par�metros
                                              //O primeiro par�metro � o �ndice inicial, e o segundo par�metro � o comprimento da substring. 
                                              //Se o segundo par�metro n�o for especificado, a substring retornar� todos os caracteres a partir do �ndice inicial.

    public void AulaRange()
    {
        string nomeArquivo = "2022_12_01_backup.bak";
        string ano = nomeArquivo[..4];// O operador de intervalo (range operator) � usado para criar um intervalo de �ndices em uma string. Nesse exemplo, ele retorna os primeiros 4 caracteres da string.
        Console.WriteLine(ano);//2022
        string extensao = nomeArquivo[^3..];//O ^ � usado para indicar que o �ndice deve ser contado a partir do final da string. Nesse exemplo, ele retorna os �ltimos 3 caracteres da string.
        Console.WriteLine(extensao); //bak

        string nome = nomeArquivo[11..^4];//Pega as letras do �ndice 11 at� o �ndice -4 (contando do final da string). Logo o ^ elimina os 4 �ltimos caracteres da string.
        Console.WriteLine(nome); // backup

        string apenasNome = nomeArquivo[..^4];
        Console.WriteLine(apenasNome);//2022_12_01_backup
    }

    public void AulaContains()
    {
        string nomeArquivo = "2022_12_01_backup.bak"; 
        if(nomeArquivo.Contains("backup_teste")) // Verifica se a string cont�m a palavra "backup_teste". O m�todo Contains retorna true se a string contiver a palavra especificada, caso contr�rio, retorna false.
        {
            Console.WriteLine("Palavra encontrada");
        }
        else
        {
            Console.WriteLine("Palavra nao encontrada");
        }
        //Console.WriteLine("Contem nome: " + nomeArquivo.Contains("backup"));//true
    }

    public void AulaTrim()
    {
        string teste = "**RENATO LUCAS**";
        //TRIM remove os espa�os em branco do in�cio e do final da string OU os caracteres especificados.
        Console.WriteLine("TOTAL: " + teste.Trim('*'));// Remove os caracteres '*' do in�cio e do final da string.
        Console.WriteLine("INICIO: " + teste.TrimStart('*'));// Remove os caracteres '*' do in�cio da string.
        Console.WriteLine("FINAL: " + teste.TrimEnd('*')); // Remove os caracteres '*' do final da string.
    }

    public void AulaStartWithEndsWith()
    {
        string teste = "Curso Csharp"; 
        
        Console.WriteLine("INICIO: " + teste.StartsWith("Curso"));// Verifica se a string come�a com a palavra "Curso". O m�todo StartsWith retorna true se a string come�ar com a palavra especificada, caso contr�rio, retorna false.
        Console.WriteLine("FINAL: " + teste.EndsWith("Csharp"));// Verifica se a string termina com a palavra "Csharp". O m�todo EndsWith retorna true se a string terminar com a palavra especificada, caso contr�rio, retorna false.
    }

    public void AulaReplace()
    {
        string teste = "Curso Csharp";  
        Console.WriteLine(teste);
        Console.WriteLine(teste.Replace("Csharp", "C#"));// Substitui a palavra "Csharp" por "C#". O m�todo Replace retorna uma nova string com as substitui��es feitas.
    }

    public void AulaLength()
    {
        string teste = Console.ReadLine(); 
        Console.WriteLine(teste);
        Console.WriteLine(teste.Length);// Retorna o comprimento da string, ou seja, o n�mero de caracteres que ela cont�m.
    }
}