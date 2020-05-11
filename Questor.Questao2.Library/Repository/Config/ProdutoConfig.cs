using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Questor.Questao2.Library.Domain.Entities;
using System;

namespace Questor.Questao2.Library.Repository.Config
{
    public class ProdutoConfig : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(x => x.ProdutoId);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Descricao).HasMaxLength(800);
            builder.Property(x => x.Preco).IsRequired();

            builder.HasOne(x => x.Categoria).WithMany(x => x.Produtos).HasForeignKey(x => x.CategoriaId);

            builder.ToTable("Produtos");
        }
    }
}
