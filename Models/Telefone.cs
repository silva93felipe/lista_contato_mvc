using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace contato_mvc.Models
{
    public class Telefone : BaseModel<int>
    {
        public int ContatoId { get; set; }
        public string Numero { get; set; }
        
    }
}