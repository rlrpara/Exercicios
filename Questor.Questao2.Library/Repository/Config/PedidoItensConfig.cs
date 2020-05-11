using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Questor.Questao2.Library.Domain.Entities;

namespace Questor.Questao2.Library.Repository.Config
{
    public class PedidoItensConfig : IEntityTypeConfiguration<PedidoItens>
    {
        public void Configure(EntityTypeBuilder<PedidoItens> builder)
        {
            builder.HasKey(x => x.PedidoItensId);
            builder.Property(x => x.Qtd).IsRequired();
            builder.Property(x => x.Valor).IsRequired();
            builder.Property(x => x.ValorTotal).IsRequired();

            builder.HasOne(x => x.Pedido).WithMany(x => x.PedidoItens).HasForeignKey(x => x.PedidoId);
            builder.HasOne(x => x.Produto).WithMany(x => x.PedidoItens).HasForeignKey(x => x.ProdutoId);

            builder.ToTable("PedidoItens");
        }
    }
}
