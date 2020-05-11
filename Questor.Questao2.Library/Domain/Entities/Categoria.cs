using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Questor.Questao2.Library.Domain.Entities
{
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
