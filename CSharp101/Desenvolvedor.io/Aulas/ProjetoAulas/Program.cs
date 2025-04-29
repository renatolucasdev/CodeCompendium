/*
 Top-level statements: 
    - Permite escrever um programa sem a necessidade de uma classe principal, como nas versões anteriores do C#.
 */

//Console.WriteLine("Primeiro programa");

using System;

namespace Application // namespace é um agrupamento de classes, interfaces, estruturas, enumerações e delegados.
{                    
    public class Program
    {
        static void Main(string[] args)// método principal, o compilador executa o método Main ao compilar o programa.
        {
            //AulaClasses();
            //AulaPropriedadeSomenteLeitura();
            //AulaHeranca();
            //AulaClasseSelada();
            //AulaClasseAbstrata(); 
            //AulaRecord();
            //AulaInterface();
            //Conversores();
            //TrabalhandoComStrings();
            //TrabalhandoComDatas();
            TrabalhandoComExcecoes();
            //TrabalhandoComArquivos();
            //TrabalhandoComLinq();
        }  


        private static void TrabalhandoComLinq()
         {
              var linq = new Modulo14.TrabalhandoComLinq();
              //linq.AulaWhere();
              //linq.AulaOrdenacao();
              //linq.AulaTake();
              //linq.AulaCount();
              linq.AulaFirstEFirstOrDefault();
         }

         private static void TrabalhandoComArquivos()
         {
                var trabalhandoComArquivos = new Modulo13.TrabalhandoComArquivos();
                //trabalhandoComArquivos.AulaCriandoArquivo();
                //trabalhandoComArquivos.AulaLendoArquivo();
                trabalhandoComArquivos.AulaExcluindoArquivo();
         }

         private static void TrabalhandoComExcecoes()
         {
                var trabalhandoComExcecoes = new Modulo12.TrabalhandoComExcecoes();
                //trabalhandoComExcecoes.AulaGerandoException();
                trabalhandoComExcecoes.AulaTratandoException();
         }

        private static void TrabalhandoComDatas()
        {
            var trabalhandoComDatas = new Modulo11.TrabalhandoComDatas();
            //trabalhandoComDatas.AulaDateTime();
            //trabalhandoComDatas.AulaSubtraindoDatas();
            //trabalhandoComDatas.AulaAdicionandoDiasMesAno();
            //trabalhandoComDatas.AulaAdicionandoHoraMinutoSegundos();
            //trabalhandoComDatas.AulaDiaDaSemana();
            //trabalhandoComDatas.AulaDateOnly();
            //trabalhandoComDatas.AulaTimeOnly();
        }

        private static void TrabalhandoComStrings()
        {
            var trabalhandoComStrings = new Modulo10.TrabalhandoComStrings();
            //trabalhandoComStrings.ConverterParaLetrasMinusculas();
            //trabalhandoComStrings.ConverterParaLetrasMaiusculas();
            //trabalhandoComStrings.AulaSubstring();
            //trabalhandoComStrings.AulaRange();
            //trabalhandoComStrings.AulaContains();
            //trabalhandoComStrings.AulaTrim();
            //trabalhandoComStrings.AulaStartWithEndsWith();
            //trabalhandoComStrings.AulaReplace();
            //trabalhandoComStrings.AulaLength();
        }

        private static void Conversores()
        {
            var conversores = new Conversores.Conversor();
           // conversores.ConvertAndParse();
           conversores.AulaTryParse();
        }

         private static void AulaInterface()
         {
            var notificacaoCliente = new Cadastro.NotificacaoCliente();
            notificacaoCliente.Notificar();
            notificacaoCliente.NotificarOutros();

            Cadastro.INotificacao notificacao = new Cadastro.NotificacaoFuncionario();//instanciando a classe NotificacaoFuncionario, que implementa a interface INotificacao. Dessa maneira, apenas os métodos e propriedades da interface INotificacao podem ser acessados, não os métodos e propriedades da classe NotificacaoFuncionario.
            notificacao.Notificar();
            
         }

         private static void AulaRecord()
         {
            //var curso1 = new Cadastro.Curso { Id = 1, Descricao = "Curso"};
            //var curso2 = new Cadastro.Curso { Id = 1, Descricao = "Curso"};

            var curso1 = new Cadastro.Curso (1,"Curso");
            var curso2 = curso1 with { Descricao = "Teste Novo"}; //criando um novo objeto com base no objeto curso1, alterando a propriedade Descricao.

            //var curso1 = new Cadastro.CursoTeste  { Id = 1, Descricao = "Curso"};
            // var curso2 = curso1;//copiando a referência do objeto curso1 para o objeto curso2
            //curso2.Descricao = "TESTE TESTE";//alterando a propriedade Descricao do objeto curso2, a propriedade Descricao do objeto curso1 também é alterada.
            //var curso2 = new Cadastro.CursoTeste();//criando um novo objeto curso2
            //curso2.Id = curso1.Id;//copiando o valor da propriedade Id do objeto curso1 para o objeto curso2
            //curso2.Descricao = "Nova descricao";//definindo o valor da propriedade Descricao do objeto curso2

            Console.WriteLine(curso1.Descricao);
            Console.WriteLine(curso2.Descricao);
            //Console.WriteLine(curso1.Equals(curso2));
            //Console.WriteLine(curso1 == curso2);//o operador == em record compara o valor das propriedades, não a referência do objeto.
        }

        private static void AulaClasseAbstrata()
         {
             var cachorro = new Cadastro.Cachorro(); 
             cachorro.Nome = "Dog"; 
             cachorro.ImprimirDados();
         }

         private static void AulaClasseSelada()
         {
               /*var configuracao = new Cadastro.Configuracao();
               configuracao.Host = "localhost";
               */
               var configuracao = new Cadastro.Configuracao
               {
                  Host = "localhost"
               };

               Console.WriteLine(configuracao.Host);

         }

         private static void AulaHeranca()
         {
            var pessoaFisica = new Cadastro.PessoaFisica();
            pessoaFisica.Id = 1;//propriedade da classe Pessoa
            pessoaFisica.Endereco = "Endereco Teste";//propriedade da classe Pessoa
            pessoaFisica.Cidade = "Cidade Teste";//propriedade da classe Pessoa
            pessoaFisica.Cep = "12345612";//propriedade da classe Pessoa
            pessoaFisica.CPF = "12345678912";//propriedade da classe PessoaFisica
            pessoaFisica.ImprimirDados();//método da classe Pessoa, herdado pela classe PessoaFisica
            pessoaFisica.ImprimirCpf();//método da classe PessoaFisica

            
            var funcionario = new Cadastro.Funcionario();//herdando os membros da classe PessoaFisica que herda os membros da classe Pessoa
            funcionario.Id = 10;//propriedade da classe Pessoa
            funcionario.Endereco = "Endereco Teste";//propriedade da classe Pessoa
            funcionario.Cidade = "Cidade Teste";//propriedade da classe Pessoa
            funcionario.Cep = "12345612";//propriedade da classe Pessoa
            funcionario.CPF = "12345678912";//propriedade da classe PessoaFisica
            funcionario.Matricula = "123456";//propriedade da classe Funcionario
            funcionario.ImprimirDados();//método da classe Pessoa, herdado pela classe PessoaFisica
            funcionario.ImprimirCpf();//método da classe PessoaFisica
            funcionario.ImprimirMatricula();//método da classe Funcionario
        }

        private static void AulaClasses()
        {
            var resultado = Cadastro.Calculos.SomarNumeros(2,3);//chamando um método estático da classe Calculos
            Console.WriteLine(resultado);
            
            var produto = new Cadastro.Produto();//instanciando um objeto da classe Produto
            produto.SetId(1); //definindo o valor da propriedade Id  

            produto.Descricao = "Teclado"; //definindo o valor da propriedade Descricao, o set é chamado de forma implícita.

            produto.ImprimirDescricao();
            Console.WriteLine(produto.GetId());
            
        }

        private static void AulaPropriedadeSomenteLeitura()
        {
      
            var produto = new Cadastro.Produto();
            produto.Descricao = "Mouse";
            //produto.Estoque = 1; //propriedade somente leitura, não é possível definir um valor para a propriedade.
            Console.WriteLine(produto.Estoque);

        }
    }
}

/*
namespace Cadastro
{
    public class Cliente
    {
    }

    public class Funcionario
    {
    } 
}


namespace Financeiro
{
    public class ContasReceber
    {
    }

    public class Funcionario
    {
    }
}*/