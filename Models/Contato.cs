using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using contato_mvc.Models;

namespace mvc.Models
{
    public class Contato : BaseModel<int>
    {
        public string Nome { get; set; }
        public List<Telefone>? Telefones { get; set; }

        public Contato()
        {
            Telefones = new List<Telefone>();
        }
    }
}