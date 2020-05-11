using System.Collections.Generic;

namespace Questor.Questao2.Library.Domain.Entities
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }

        public virtual ICollection<Lancamentos> Lancalentos { get; set; }
        public virtual ICollection<PedidoItens> PedidoItens { get; set; }
    }
}
