namespace Modulo13;

public class TrabalhandoComArquivos
{
    public void AulaCriandoArquivo()
    {
        var escrever = new StreamWriter("Cadastro.txt", true);// Cria o arquivo Cadastro.txt, se não existir, e abre para escrita. O segundo parâmetro (true) indica que o arquivo será aberto para adicionar conteúdo, em vez de sobrescrever o existente...
        Console.Write("Informe um nome: ");                  //... Caso não seja passado o caminho do arquivo, o arquivo será criado na pasta do projeto. Se o arquivo já existir, o conteúdo será adicionado ao final do arquivo existente.
        var nome = Console.ReadLine();
        escrever.WriteLine("ID...: " + Random.Shared.Next(1, 100)); // Gera um número aleatório entre 1 e 100.
        escrever.WriteLine("Nome.: " + nome);
        escrever.WriteLine("----------------------");
        escrever.Close();// Fecha o arquivo após a escrita.
    }

    public void AulaLendoArquivo()
    {
        //var conteudo = File.ReadAllText("Cadastro.txt");// Lê todo o conteúdo do arquivo de uma vez.

        //Console.WriteLine(conteudo);

        var ler = new StreamReader("Cadastro.txt");// Lê o arquivo linha por linha.
        while (!ler.EndOfStream)// Verifica se o arquivo não chegou ao fim (EOF - End Of File).
        {
            var linha = ler.ReadLine();
            Console.WriteLine(linha);
        }

        ler.Close();
    }

    public void AulaExcluindoArquivo()
    {
        if(File.Exists("Cadastro.txt"))// Verifica se o arquivo existe antes de tentar excluí-lo.
        {
            File.Delete("Cadastro.txt");// Exclui o arquivo.
        }
    }
}