/*
  4 pilares da POO:
- Abstração: é a capacidade de abstrair um objeto do mundo real e transformá-lo em um objeto de software.
- Encapsulamento: é a capacidade de esconder a implementação interna de um objeto e mostrar apenas o que é necessário para o usuário. Apenas métodos e propriedades públicas são visíveis.
- Herança: é a capacidade de criar uma nova classe a partir de uma classe existente. A nova classe herda todos os métodos e propriedades da classe existente.
- Polimorfismo: é a capacidade de um objeto se comportar de várias maneiras. Por exemplo, um objeto pode ser tratado como um objeto de sua classe base ou como um objeto de sua classe derivada.

 Classe:
    - É um tipo de dado que contém membros, como métodos e propriedades. Uma classe abstrai o comportamento e as características de um objeto do mundo real.
 Objeto: 
   - É uma instância de uma classe.

 */

//namespace Cadastro;

namespace Cadastro
{
    //classe estática, não pode ser instanciada. Não é gerenciada pelo coletor de lixo. É responsabilidade do desenvolvedor liberar os recursos.
    public static class Calculos
    {
        public static int SomarNumeros(int a, int b)//método estático, pode ser chamado sem instanciar um objeto da classe.
        {
            return a + b;
        }
    }

   public class Produto //class define uma classe, public permite que a classe seja acessada por outras classes.
    {
      //membros da classe
      private int Id; //propriedade privada, só pode ser acessada dentro da classe.

      public string Descricao { get; set; } //propriedade. get e set são acessadores de propriedade. get é usado para retornar o valor da propriedade e set é usado para definir o valor da propriedade.

        
      public int Estoque {get; }//propriedade somente leitura, o seu valor só pode ser definido no construtor da classe.
                                //public readonly int Estoque;//outra forma de definir uma propriedade somente leitura

      public Produto()//método construtor, possui o mesmo nome da classe e é chamado quando um objeto é instanciado.
      {
         Estoque = 1;//definindo o valor da propriedade Estoque, que é somente leitura.
      }

      public void ImprimirDescricao()//método, public permite que o método seja acessado por outras classes.
      {
            Console.WriteLine(GetId() + " - " + Descricao);
      }

      public void SetId(int id)//método que define o valor da propriedade Id, que é acessível somente dentro da classe.
        {
            Id = id;
      }

      public int GetId()//método que retorna o valor da propriedade Id, que é acessível somente dentro da classe.
        {
            return Id;
      }

   }

    public class Pessoa
    {
        public int Id {get;set;}
        public string Endereco {get;set;}
        public string Cidade {get;set;}
        public string Cep {get;set;}

        public void ImprimirDados()
        {
            Console.WriteLine("Codigo: " + Id);
            Console.WriteLine("Endereco: " + Endereco);
            Console.WriteLine("Cidade: " + Cidade);
            Console.WriteLine("Cep: " + Cep);
        }
    }

    public class PessoaFisica : Pessoa //herança, a classe PessoaFisica herda os membros da classe Pessoa.
    {
        public string CPF {get;set;}

        public void ImprimirCpf()
        {
            Console.WriteLine("CPF: " + CPF);
        }
    }

    public class Funcionario : PessoaFisica
    {
        public string Matricula {get;set;}

        public void ImprimirMatricula()
        {
            Console.WriteLine("Matricula: " + Matricula);
        }
    }
    

    public sealed class Configuracao //classe selada, não pode ser herdada.
    {
        public string Host {get;set;}
    }


    public abstract class Animal //classe abstrata(superclasse), não pode ser instanciada. Pode conter métodos abstratos e virtuais.
    {                            //funciona como um contrato para as classes que a herdam.
        public string Nome {get;set;}

        public abstract string GetInformacoes(); //método abstrato, não possui implementação. Deve ser implementado nas classes que herdam de Animal.

        public virtual void ImprimirDados() //método virtual, pode ser sobrescrito ou chamado nas classes que herdam de Animal
        {
            Console.WriteLine("Nome animal: " + Nome);
            Console.WriteLine("Informacoes: " + GetInformacoes());
        }
    }

    public class Cachorro : Animal //classe que herda de Animal(subclasse).
    {
        public override string GetInformacoes() //método abstrato sobrescrito, obrigatório implementar nas classes que herdam de Animal.
        {
            return "Cachorro é um bom amigo";
        }

        public override void ImprimirDados()
        {
            base.ImprimirDados(); //chamando o método da superclasse.
            Console.WriteLine("Metodo chamando dentro da classe cachorro");
        } 
    }   

    public record Curso(int Id, string Descricao);//record, classe que armazena dados imutáveis. Possui métodos Equals e GetHashCode implementados.

    public class CursoTeste
    {
        public int Id { get; set; } //prop + tab cria um modelo de propriedade
        public string Descricao { get; set; }
    }

    /*
    public record Curso
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public override bool Equals(object? obj)//sobrescrevendo o método Equals da classe Object´para comparar objetos do tipo Curso.
        {
            if(obj == null) return false;

            if(obj is Curso curso)
            {
                return Id == curso.Id && Descricao == curso.Descricao;
            }

            return base.Equals(obj);
        }

        public static bool operator == (Curso a, Curso b) //sobrescrevendo o operador == para comparar objetos do tipo Curso.
        {
            return a.Equals(b);
        }

        public static bool operator != (Curso a, Curso b)//sobrescrevendo o operador != para comparar objetos do tipo Curso.
        {
            return !(a == b);
        }
    }*/

    public interface INotificacao //interface, define um contrato para as classes que a implementam. Pode conter métodos e propriedades.
    {
        string Descricao {get;set;}
        void Notificar();
    }

    public class NotificacaoCliente : INotificacao //classe que implementa a interface INotificacao.
    {
        public string Descricao { get; set; } //propriedade da interface INotificacao, obrigatória na classe que implementa a interface.

        public void Notificar()//método da interface INotificacao, obrigatória na classe que implementa a interface.
        {
            Console.WriteLine("Notificando cliente");
        }

         public void NotificarOutros()//método adicional, não faz parte da interface INotificacao.
        {
            Console.WriteLine("Notificando outros");
        }
    }

    public class NotificacaoFuncionario : INotificacao
    {
        public string Descricao { get; set; }

        public void Notificar()
        {
            Console.WriteLine("Notificando funcionario");
        }

        public void NotificarOutros()
        {
            Console.WriteLine("Notificando outros");
        }
    }
}
