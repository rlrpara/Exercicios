using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Questor.Questao2.Library.Domain.Entities;

namespace Questor.Questao2.Library.Repository.Config
{
    public class LancamentosConfig : IEntityTypeConfiguration<Lancamentos>
    {
        public void Configure(EntityTypeBuilder<Lancamentos> builder)
        {
            builder.HasKey(x => x.LancamentoId);
            builder.Property(x => x.Observacao).HasMaxLength(800);
            builder.Property(x => x.Quantidade).IsRequired();
            builder.Property(x => x.DataLancamento);

            builder.HasOne(x => x.Produto).WithMany(x => x.Lancalentos).HasForeignKey(x => x.ProdutoId);

            builder.ToTable("Lançamentos");
        }
    }
}
