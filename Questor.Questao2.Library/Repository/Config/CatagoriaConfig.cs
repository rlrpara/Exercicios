using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Questor.Questao2.Library.Domain.Entities;

namespace Questor.Questao2.Library.Repository.Config
{
    public class CatagoriaConfig : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(x => x.CategoriaId);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Descricao).HasMaxLength(800);

            builder.ToTable("Categoria");
        }
    }
}
