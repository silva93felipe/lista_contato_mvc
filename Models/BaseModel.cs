using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace contato_mvc.Models
{
    public abstract class BaseModel<T>
    {
        public T Id { get; set ; }
        public bool Ativo { get; set; }

        [Display(Name = "Cadastro")]
        public DateTime CreatAt { get; private set; }
        public DateTime UpdateAt { get; set; }

        public BaseModel()
        {
            Ativo = true;
            CreatAt = DateTime.UtcNow;
            UpdateAt = DateTime.UtcNow;
        }
    }
}