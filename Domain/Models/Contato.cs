namespace contato_mvc.Domain.Models
{
    public class Contato : BaseModel<int>
    {
        public string Nome { get; private set; }
        public List<Telefone>? Telefones { get; }

        public Contato(string name)
        {
            Nome = name;
            Telefones = new List<Telefone>();
        }

        public void AdicionarTelefone(Telefone telefone){
            Telefones?.Add(telefone);
        }

        public void RemoverTelefone(Telefone telefone){
            Telefones?.Remove(telefone);
        }

        public override void Inativar()
        {
            Telefones?.ForEach(t => t.Inativar());
            base.Inativar();
        }
    }
}