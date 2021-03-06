﻿using Questor.Questao2.Library.Contexto;
using Questor.Questao2.Library.Domain.Entities;
using Questor.Questao2.Library.Domain.Interfaces;

namespace Questor.Questao2.Library.Repository
{
    public class PedidoRepository : BaseRepository<Pedido>, IPedidoReporitory
    {
        public PedidoRepository(QuestorContext questorContext) : base(questorContext)
        {
        }
    }
}
