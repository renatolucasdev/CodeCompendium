using IntroducaoEFCore.Domain;
using Microsoft.EntityFrameworkCore;

namespace IntroducaoEFCore.Data
{
    public class ApplicationContext : DbContext
    {
        //Propriedade que serve para identificar quais entidades estão envolvidas nas operações. Isso permite que gere os comandos SQL necessários para lidar com os dados dessas entidades. Sem um DbSet, o Entity Framework Core não processa operações com as entidades.
        public DbSet<Pedido> Pedidos { get; set; } //Todas as classes do Domain serão reconhecidas, pois estão todas relacionadas na classe Pedido
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //Método que configura o DbContext
        {
            //Informando o provedor de banco de dados e a string de conexão
            optionsBuilder.UseSqlServer("Server=RENATUS-PC\\SQLEXPRESS;Database=IntroEFCore;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ///Dinâmica da Fluent API
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly); //Aplica todas as configurações de mapeamento de entidades do assembly atual
            //O que ele faz nesse caso é pegar uma classe de referência e através do assemblie dessa classe, ele encontra todas as outras classes que fazem parte da configuração. Poderia ser uma outra classe mas como padrão a gente usa o contexto
        }
    }
}
