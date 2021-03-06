﻿using Questor.Questao2.Library.Contexto;
using Questor.Questao2.Library.Domain.Entities;
using Questor.Questao2.Library.Domain.Interfaces;

namespace Questor.Questao2.Library.Repository
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(QuestorContext questorContext) : base(questorContext)
        {
        }
    }
}
