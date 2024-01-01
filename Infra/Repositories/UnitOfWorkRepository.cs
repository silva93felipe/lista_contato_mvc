using contato_mvc.Domain.Interfaces.Repositories;
using contato_mvc.Infra.Context;

namespace contato_mvc.Infra.Repository{
    public class UnitOfWorkRepository : IUnitOfWorkRepository
    {
        private readonly AgendaContext _agendaContext;

        public UnitOfWorkRepository(AgendaContext agendaContext)
        {
            _agendaContext = agendaContext;
        }
        public void Commit()
        {
            _agendaContext.SaveChanges();
        }

        public void RollBack(){}
    }
}