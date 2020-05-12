using Questor.Questao2.Library.Contexto;
using Questor.Questao2.Library.Domain.Entities;
using Questor.Questao2.Library.Domain.Interfaces;

namespace Questor.Questao2.Library.Repository
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(QuestorContext questorContext) : base(questorContext)
        {
        }
    }
}
