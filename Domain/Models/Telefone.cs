namespace contato_mvc.Domain.Models
{
    public class Telefone : BaseModel<int>
    {
        public int ContatoId { get; private set; }
        public string Numero { get; private set; }

        public Telefone(int contatoId, string numero){
            ContatoId = contatoId;
            Numero = numero;
        }

        public void AtualizarNumero(string numero){
            Numero = numero;
        }
        
    }
}