using contato_mvc.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace contato_mvc.Infra.Context{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options){}
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Telefone> Telefone { get; set; }
    }
}