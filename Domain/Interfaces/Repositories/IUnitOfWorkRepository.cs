namespace contato_mvc.Domain.Interfaces.Repositories{
    public interface IUnitOfWorkRepository{
        void Commit();
        void RollBack();
    }
}
