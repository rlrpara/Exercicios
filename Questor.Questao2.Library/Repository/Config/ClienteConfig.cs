using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Questor.Questao2.Library.Domain.Entities;

namespace Questor.Questao2.Library.Repository.Config
{
    public class ClienteConfig : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(x => x.ClienteId);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(50);

            builder.ToTable("Clientes");
        }
    }
}
