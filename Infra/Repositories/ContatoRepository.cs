using contato_mvc.Domain.Interfaces.Repositories;
using contato_mvc.Domain.Models;
using contato_mvc.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace contato_mvc.Infra.Repository{
    public class ContatoRepository : IContatoRepository
    {
        private readonly AgendaContext _agendaContext;

        public ContatoRepository(AgendaContext agendaContext)
        {
            _agendaContext = agendaContext;
        }

        public async Task Add(Contato contato)
        {
            await _agendaContext.AddAsync(contato);
        }

        public IEnumerable<Contato> GetAll()
        {
            return _agendaContext.Contatos.ToList();
        }

        public Contato GetById(int contatoId)
        {
            return _agendaContext.Contatos.Find(contatoId);
        }

        public async Task Remove(int contatoId)
        {
            var contato = await _agendaContext.Contatos.Where(c => c.Id == contatoId).FirstOrDefaultAsync();
            contato?.Inativar();
        }
    }
}