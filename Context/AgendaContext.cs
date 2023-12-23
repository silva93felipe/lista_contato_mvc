using contato_mvc.Models;
using Microsoft.EntityFrameworkCore;
using mvc.Models;

namespace mvc.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options){

        }

        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Telefone> Telefone { get; set; }
        
    }
}