﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Questor.Questao2.Library.Domain.Entities
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
