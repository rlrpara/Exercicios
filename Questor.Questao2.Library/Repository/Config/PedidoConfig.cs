using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Questor.Questao2.Library.Domain.Entities;

namespace Questor.Questao2.Library.Repository.Config
{
    public class PedidoConfig : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(x => x.PedidoId);
            builder.Property(x => x.DataVenda).IsRequired();
            builder.Property(x => x.QtdTotal).IsRequired();
            builder.Property(x => x.ValorTotal);

            builder.HasOne(x => x.Cliente).WithMany(x => x.Pedidos).HasForeignKey(x => x.ClienteId);

            builder.ToTable("Pedido");
        }
    }
}
