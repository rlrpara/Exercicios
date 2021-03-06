﻿using Questor.Questao2.Library.Contexto;
using Questor.Questao2.Library.Domain.Entities;
using Questor.Questao2.Library.Domain.Interfaces;

namespace Questor.Questao2.Library.Repository
{
    public class CategoriaRepository : BaseRepository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(QuestorContext questorContext) : base(questorContext)
        {
        }
    }
}
