using Questor.Questao2.Library.Contexto;
using Questor.Questao2.Library.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Questor.Questao2.Library.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly QuestorContext _questorContext;
        public BaseRepository(QuestorContext questorContext)
        {
            _questorContext = questorContext;
        }
        public void Adicionar(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Apagar(int id)
        {
            var entity = ObterPorId(id);
            _questorContext.Set<TEntity>().Remove(entity);
            _questorContext.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            _questorContext.Set<TEntity>().Update(entity);
            _questorContext.SaveChanges();
        }

        public TEntity ObterPorId(int id)
        {
            return _questorContext.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return _questorContext.Set<TEntity>().ToList();
        }
    }
}
