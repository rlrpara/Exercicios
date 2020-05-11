namespace Questor.Questao2.Library.Domain.Entities
{
    public class PedidoItens
    {
        public int PedidoItensId { get; set; }
        public int PedidoId { get; set; }
        public virtual Pedido Pedido { get; set; }
        public int ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }
        public int Qtd { get; set; }
        public decimal Valor { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
