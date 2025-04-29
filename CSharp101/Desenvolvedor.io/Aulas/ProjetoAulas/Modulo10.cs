namespace Modulo10;

public class TrabalhandoComStrings
{
    public void ConverterParaLetrasMinusculas()
    {
        Console.Write("Favor digitar alguma informacao: ");
        var linha = Console.ReadLine(); // Lê uma linha de texto do console.
        Console.WriteLine(linha.ToLower());// Converte a string para letras minúsculas. Útil para normalizar entradas de texto.
    }

    public void ConverterParaLetrasMaiusculas()
    {
        Console.Write("Favor digitar alguma informacao: ");
        var linha = Console.ReadLine();
        Console.WriteLine(linha.ToUpper());// Converte a string para letras maiúsculas. Útil para normalizar entradas de texto.
    }

     public void AulaSubstring()
    {
        Console.Write("Favor digitar alguma informacao: ");
        var linha = Console.ReadLine();
        Console.WriteLine(linha.Substring(6));// Substring é um método que retorna uma parte da string original, começando do índice especificado até o final da string.
    }                                         //Possui 2 parâmetros
                                              //O primeiro parâmetro é o índice inicial, e o segundo parâmetro é o comprimento da substring. 
                                              //Se o segundo parâmetro não for especificado, a substring retornará todos os caracteres a partir do índice inicial.

    public void AulaRange()
    {
        string nomeArquivo = "2022_12_01_backup.bak";
        string ano = nomeArquivo[..4];// O operador de intervalo (range operator) é usado para criar um intervalo de índices em uma string. Nesse exemplo, ele retorna os primeiros 4 caracteres da string.
        Console.WriteLine(ano);//2022
        string extensao = nomeArquivo[^3..];//O ^ é usado para indicar que o índice deve ser contado a partir do final da string. Nesse exemplo, ele retorna os últimos 3 caracteres da string.
        Console.WriteLine(extensao); //bak

        string nome = nomeArquivo[11..^4];//Pega as letras do índice 11 até o índice -4 (contando do final da string). Logo o ^ elimina os 4 últimos caracteres da string.
        Console.WriteLine(nome); // backup

        string apenasNome = nomeArquivo[..^4];
        Console.WriteLine(apenasNome);//2022_12_01_backup
    }

    public void AulaContains()
    {
        string nomeArquivo = "2022_12_01_backup.bak"; 
        if(nomeArquivo.Contains("backup_teste")) // Verifica se a string contém a palavra "backup_teste". O método Contains retorna true se a string contiver a palavra especificada, caso contrário, retorna false.
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
        //TRIM remove os espaços em branco do início e do final da string OU os caracteres especificados.
        Console.WriteLine("TOTAL: " + teste.Trim('*'));// Remove os caracteres '*' do início e do final da string.
        Console.WriteLine("INICIO: " + teste.TrimStart('*'));// Remove os caracteres '*' do início da string.
        Console.WriteLine("FINAL: " + teste.TrimEnd('*')); // Remove os caracteres '*' do final da string.
    }

    public void AulaStartWithEndsWith()
    {
        string teste = "Curso Csharp"; 
        
        Console.WriteLine("INICIO: " + teste.StartsWith("Curso"));// Verifica se a string começa com a palavra "Curso". O método StartsWith retorna true se a string começar com a palavra especificada, caso contrário, retorna false.
        Console.WriteLine("FINAL: " + teste.EndsWith("Csharp"));// Verifica se a string termina com a palavra "Csharp". O método EndsWith retorna true se a string terminar com a palavra especificada, caso contrário, retorna false.
    }

    public void AulaReplace()
    {
        string teste = "Curso Csharp";  
        Console.WriteLine(teste);
        Console.WriteLine(teste.Replace("Csharp", "C#"));// Substitui a palavra "Csharp" por "C#". O método Replace retorna uma nova string com as substituições feitas.
    }

    public void AulaLength()
    {
        string teste = Console.ReadLine(); 
        Console.WriteLine(teste);
        Console.WriteLine(teste.Length);// Retorna o comprimento da string, ou seja, o número de caracteres que ela contém.
    }
}