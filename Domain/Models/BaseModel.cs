namespace contato_mvc.Domain.Models
{
    public abstract class BaseModel<T>
    {
        public T Id { get; private set ; }
        public bool Ativo { get; private set; }
        public DateTime CreatAt { get; private set; }        
        public DateTime UpdateAt { get; set; }

        public BaseModel()
        {
            Ativo = true;
            CreatAt = DateTime.Now;
            UpdateAt = DateTime.Now;
        }

        public virtual void Inativar(){
            Ativo = false;
            UpdateAt = DateTime.Now;
        }
    }
}