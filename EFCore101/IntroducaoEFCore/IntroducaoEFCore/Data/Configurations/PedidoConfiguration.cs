using IntroducaoEFCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IntroducaoEFCore.Data.Configurations
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("Pedidos");
            builder.HasKey(p => p.Id); //Chave primária da tabela
            builder.Property(p => p.IniciadoEm).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd(); //Valor padrão para a coluna IniciadoEm, que é a data de criação do pedido
            builder.Property(p => p.Status).HasConversion<string>(); //Converter o enum StatusPedido para string no banco de dados
            builder.Property(p => p.TipoFrete).HasConversion<int>(); //Mantém o enum TipoFrete como inteiro no banco de dados
            builder.Property(p => p.Observacao).HasColumnType("VARCHAR(512)"); //Limite de 500 caracteres para a observação do pedido

            builder.HasMany(p => p.Itens)//Relacionamento entre Pedido e PedidoItem (1:N)
                .WithOne(p => p.Pedido)//Relacionamento entre Pedido e PedidoItem
                .OnDelete(DeleteBehavior.Cascade); //Quando um pedido for excluído, todos os itens relacionados a ele também serão excluídos. Isso é chamado de exclusão em cascata.
        }
        
    }
}
