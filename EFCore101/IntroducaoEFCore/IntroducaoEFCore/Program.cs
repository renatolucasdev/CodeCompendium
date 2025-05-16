using System;
using System.Collections.Generic;
using System.Linq;
using IntroducaoEFCore.Data;
using IntroducaoEFCore.Domain;
using IntroducaoEFCore.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace CursoEFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            /*using var db = new Data.ApplicationContext();
            db.Database.Migrate(); // Executa as migrações pendentes. Não é a forma mais indicada de fazer isso em produção, mas para fins de aprendizado é interessante

            var existe = db.Database.GetPendingMigrations().Any(); // Verifica se existem migrações pendentes
            if(existe)
            {
                // 
            }*/

            //InserirDados();
            //InserirDadosEmMassa();
            //ConsultarDados();
            //CadastrarPedido();
            //ConsultarPedidoCarregamentoAdiantado();
            //AtualizarDados();
            RemoverRegistro();
        }

        private static void RemoverRegistro()
        {
            using var db = new ApplicationContext();

            //var cliente = db.Clientes.Find(2);
            var cliente = new Cliente { Id = 2 };
            //db.Clientes.Remove(cliente);
            //db.Remove(cliente);
            db.Entry(cliente).State = EntityState.Deleted; // Remove o cliente do contexto. Isso é útil quando você tem um objeto que não está sendo rastreado pelo contexto, mas você quer que ele seja removido do banco de dados. O Entity Framework Core irá gerar o comando SQL DELETE para remover o cliente do banco de dados.

            db.SaveChanges(); // Salva as alterações no banco de dados. O método SaveChanges() retorna o número de registros afetados, ou seja, o número de entidades que foram inseridas, atualizadas ou excluídas no banco de dados.
        }

        private static void AtualizarDados()
        {
            using var db = new ApplicationContext();
            //var cliente = db.Clientes.Find(1);

            var cliente = new Cliente
            {
                Id = 1
            };

            var clienteDesconectado = new
            {
                Nome = "Cliente Desconectado Passo 3",
                Telefone = "7966669999"
            };

            db.Attach(cliente); // Adiciona o cliente ao contexto, mas não altera o estado dele
            db.Entry(cliente).CurrentValues.SetValues(clienteDesconectado);// Atualiza os valores do cliente com os valores do clienteDesconectado. Isso é útil quando você tem um objeto que não está sendo rastreado pelo contexto, mas você quer que ele seja atualizado no banco de dados.

            //db.Clientes.Update(cliente);// Atualiza o cliente no contexto. Isso é útil quando você tem um objeto que está sendo rastreado pelo contexto e você quer que ele seja atualizado no banco de dados. Evitar essa abordagem pois atualiza todos os campos do cliente, mesmo os que não foram alterados.
            db.SaveChanges();
        }

        private static void ConsultarPedidoCarregamentoAdiantado()
        {
            using var db = new ApplicationContext();
            var pedidos = db
                .Pedidos
                .Include(p => p.Itens) // Carrega os itens do pedido
                    .ThenInclude(p => p.Produto)// Carrega o produto de cada item do pedido
                .ToList();

            Console.WriteLine(pedidos.Count);
        }

        private static void CadastrarPedido()
        {
            using var db = new ApplicationContext();

            var cliente = db.Clientes.FirstOrDefault();// Buscando o primeiro cliente cadastrado
            var produto = db.Produtos.FirstOrDefault();// Buscando o primeiro produto cadastrado

            var pedido = new Pedido
            {
                ClienteId = cliente.Id,
                IniciadoEm = DateTime.Now,
                FinalizadoEm = DateTime.Now,
                Observacao = "Pedido Teste",
                Status = StatusPedido.Analise,
                TipoFrete = TipoFrete.SemFrete,
                Itens = new List<PedidoItem>
                 {
                     new PedidoItem
                     {
                         ProdutoId = produto.Id,
                         Desconto = 0,
                         Quantidade = 1,
                         Valor = 10,
                     }
                 }
            };

            db.Pedidos.Add(pedido);

            db.SaveChanges();
        }

        private static void ConsultarDados()
        {
            using var db = new ApplicationContext();
            //var consultaPorSintaxe = (from c in db.Clientes where c.Id>0 select c).ToList();
            var consultaPorMetodo = db.Clientes
                .Where(p => p.Id > 0)
                .OrderBy(p => p.Id)
                .ToList();

            foreach (var cliente in consultaPorMetodo)
            {
                Console.WriteLine($"Consultando Cliente: {cliente.Id}");
                //db.Clientes.Find(cliente.Id);
                db.Clientes.FirstOrDefault(p => p.Id == cliente.Id);// Retorna o primeiro cliente que atende a condição ou null
            }
        }

        private static void InserirDadosEmMassa()
        {
            var produto = new Produto
            {
                Descricao = "Produto Teste",
                CodigoBarras = "1234567891231",
                Valor = 10m,
                TipoProduto = TipoProduto.MercadoriaParaVenda,
                Ativo = true
            };

            var cliente = new Cliente
            {
                Nome = "Renato Lucas",
                CEP = "99999000",
                Cidade = "Formiga",
                Estado = "MG",
                Telefone = "99000001111",
            };

            var listaClientes = new[]
            {
                new Cliente
                {
                    Nome = "Teste 1",
                    CEP = "99999000",
                    Cidade = "Belo Horizonte",
                    Estado = "MG",
                    Telefone = "99000001115",
                },
                new Cliente
                {
                    Nome = "Teste 2",
                    CEP = "99999000",
                    Cidade = "Itabaiana",
                    Estado = "SE",
                    Telefone = "99000001116",
                },
            };


            using var db = new ApplicationContext();
            //db.AddRange(produto, cliente); // Adiciona o produto e o cliente ao contexto
            db.Set<Cliente>().AddRange(listaClientes);// Adiciona a lista de clientes ao contexto
            //db.Clientes.AddRange(listaClientes);// Adiciona a lista de clientes ao contexto

            var registros = db.SaveChanges();
            Console.WriteLine($"Total Registro(s): {registros}");
        }

        private static void InserirDados()
        {
            var produto = new Produto
            {
                Descricao = "Produto Teste",
                CodigoBarras = "1234567891231",
                Valor = 10m,
                TipoProduto = TipoProduto.MercadoriaParaVenda,
                Ativo = true
            };

            using var db = new ApplicationContext();
            db.Produtos.Add(produto); // Adiciona o produto ao contexto
            db.Set<Produto>().Add(produto); // Adiciona o produto ao contexto
            db.Entry(produto).State = EntityState.Added;// Adiciona o produto ao contexto. Informa que o estado do produto é "Adicionado". Isso é útil quando você tem um objeto que não está sendo rastreado pelo contexto, mas você quer que ele seja adicionado ao banco de dados.
                                                        // Se as três linhas acima forem utilizadas, o produto será adicionado três vezes ao contexto, o que não é necessário. O Entity Framework Core irá rastrear as alterações e apenas persistir uma vez no banco de dados.

            var registros = db.SaveChanges();// Salva as alterações no banco de dados. O método SaveChanges() retorna o número de registros afetados, ou seja, o número de entidades que foram inseridas, atualizadas ou excluídas no banco de dados.
            Console.WriteLine($"Total Registro(s): {registros}");
        }
    }
}