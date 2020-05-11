using System;
using System.Collections.Generic;

namespace Questor.Questao2.Library.Domain.Entities
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public DateTime DataVenda { get; set; }
        public int QtdTotal { get; set; }
        public decimal ValorTotal { get; set; }
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }

        public virtual ICollection<PedidoItens> PedidoItens { get; set; }
    }
}
