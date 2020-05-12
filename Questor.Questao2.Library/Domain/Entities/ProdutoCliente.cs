namespace Questor.Questao2.Library.Domain.Entities
{
    public class ProdutoCliente
    {
        public int ProdutoClienteId { get; set; }
        public string ProdutoNome { get; set; }
        public int ClienteId { get; set; }
        public string ClienteNome { get; set; }
    }
}
