using contato_mvc.Domain.Models;

namespace contato_mvc.Domain.Interfaces.Repositories{
    public interface IContatoRepository{
        Task Add(Contato contato);
        Task Remove(int contatoId);
    }
}
