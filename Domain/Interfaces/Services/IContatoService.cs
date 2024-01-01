using contato_mvc.Domain.Models;

namespace contato_mvc.Domain.Interfaces.Services
{
    public interface IContatoService
    {
        Task Add(Contato contato);
        Task Remove(int contatoId);
        IEnumerable<Contato> GetAll();
        Contato GetById(int contatoId);
    }
}