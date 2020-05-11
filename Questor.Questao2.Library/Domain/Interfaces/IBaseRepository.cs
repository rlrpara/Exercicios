using System.Collections.Generic;

namespace Questor.Questao2.Library.Domain.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Adicionar(TEntity entity);
        void Atualizar(TEntity entity);
        IEnumerable<TEntity> ObterTodos();
        TEntity ObterPorId(int id);
        void Apagar(int id);
    }
}
