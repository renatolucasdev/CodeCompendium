using System.Globalization;
using Repositorio;

namespace AppClientes;

class Program
{
    static ClienteRepositorio _clienteRepositorio  = new ClienteRepositorio();// Instancia o repositório de clientes

    static void Main(string[] args)
    {
        var cultura = new CultureInfo("pt-BR"); // Define a cultura para pt-BR (Português do Brasil)
        Thread.CurrentThread.CurrentCulture = cultura; // Define a cultura atual do thread. Thread é a execução do programa
        Thread.CurrentThread.CurrentUICulture = cultura; // Define a cultura atual do thread para interface do usuário

        _clienteRepositorio.LerDadosClientes();

        while(true) // Loop infinito para manter o menu ativo
        {
            Menu();

            Console.ReadKey();// Aguarda o usuário pressionar uma tecla antes de continuar
.        }
    }

    static void Menu()
    {
        Console.Clear();

        Console.WriteLine("Cadastro de Clientes");
        Console.WriteLine("--------------------");
        Console.WriteLine("1 - Cadastrar Cliente");
        Console.WriteLine("2 - Exibir Clientes");
        Console.WriteLine("3 - Editar Cliente");
        Console.WriteLine("4 - Excluir Cliente");
        Console.WriteLine("5 - Sair");
        Console.WriteLine("--------------------");

        EscolherOpcao();
    }

    
    static void EscolherOpcao()
    {
        Console.Write("Escolha uma opção: ");

        var opcao = Console.ReadLine();

        switch (int.Parse(opcao))
        {
            case 1:
                {
                    _clienteRepositorio.CadastrarCliente();
                    Menu();
                    break;
                }
            case 2:
                {
                    _clienteRepositorio.ExibirClientes();
                    Menu();
                    break;
                }
            case 3:
                {
                    _clienteRepositorio.EditarCliente();
                    Menu();
                    break;
                }
            case 4:
                {
                    _clienteRepositorio.ExcluirCliente();
                    Menu();
                    break;
                }
            case 5:
                {
                    _clienteRepositorio.GravarDadosClientes();
                    Environment.Exit(0);// Encerra o programa
                    break;
                }
            default:
                {
                    Console.Clear();
                    Console.WriteLine("Opção Inválida!"); 
                    break;
                }
        }
    }
}
