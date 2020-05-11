using System;

namespace Questor.Questao2.Library.Domain.Entities
{
    public class Lancamentos
    {
        public int LancamentoId { get; set; }
        public int ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }
        public string Observacao { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataLancamento { get; set; }
    }
}
