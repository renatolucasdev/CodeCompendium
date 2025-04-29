namespace Modulo13;

public class TrabalhandoComArquivos
{
    public void AulaCriandoArquivo()
    {
        var escrever = new StreamWriter("Cadastro.txt", true);// Cria o arquivo Cadastro.txt, se n�o existir, e abre para escrita. O segundo par�metro (true) indica que o arquivo ser� aberto para adicionar conte�do, em vez de sobrescrever o existente...
        Console.Write("Informe um nome: ");                  //... Caso n�o seja passado o caminho do arquivo, o arquivo ser� criado na pasta do projeto. Se o arquivo j� existir, o conte�do ser� adicionado ao final do arquivo existente.
        var nome = Console.ReadLine();
        escrever.WriteLine("ID...: " + Random.Shared.Next(1, 100)); // Gera um n�mero aleat�rio entre 1 e 100.
        escrever.WriteLine("Nome.: " + nome);
        escrever.WriteLine("----------------------");
        escrever.Close();// Fecha o arquivo ap�s a escrita.
    }

    public void AulaLendoArquivo()
    {
        //var conteudo = File.ReadAllText("Cadastro.txt");// L� todo o conte�do do arquivo de uma vez.

        //Console.WriteLine(conteudo);

        var ler = new StreamReader("Cadastro.txt");// L� o arquivo linha por linha.
        while (!ler.EndOfStream)// Verifica se o arquivo n�o chegou ao fim (EOF - End Of File).
        {
            var linha = ler.ReadLine();
            Console.WriteLine(linha);
        }

        ler.Close();
    }

    public void AulaExcluindoArquivo()
    {
        if(File.Exists("Cadastro.txt"))// Verifica se o arquivo existe antes de tentar exclu�-lo.
        {
            File.Delete("Cadastro.txt");// Exclui o arquivo.
        }
    }
}