using IntroducaoEFCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IntroducaoEFCore.Data.Configurations
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes"); //Nome da tabela no banco de dados
            builder.HasKey(c => c.Id); //Chave primária da tabela
            builder.Property(c => c.Nome).HasColumnType("VARCHAR(80)").IsRequired(); //Nome da coluna no banco de dados, tipo e se é obrigatório
            builder.Property(c => c.Telefone).HasColumnType("CHAR(11)").IsRequired(); //CHAR(11) faz alocação de memória fixa (estática), enquanto VARCHAR(11) faz alocação de memória variável (dinâmica)
            builder.Property(c => c.CEP).HasColumnType("CHAR(8)").IsRequired();
            builder.Property(c => c.Estado).HasColumnType("CHAR(2)").IsRequired();
            builder.Property(c => c.Cidade).HasMaxLength(60); //O EF Core entende que é um campo varchar, pois a propriedade é do tipo string, então não precisa especificar o tipo

            builder.HasIndex(i => i.Telefone).HasDatabaseName("idx_cliente_telefone"); //criando um índice no banco de dados
        }
    }
    
    
}
