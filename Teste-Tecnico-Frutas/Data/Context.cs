using Microsoft.EntityFrameworkCore;
using Teste_Tecnico_Frutas.Models;

namespace Teste_Tecnico_Frutas.Data
{
    public class Context : DbContext
    {
        public Context() { }
        public DbSet<Fruta> Frutas { get; set; }
        public Context(DbContextOptions<Context> opcoes) : base(opcoes) { }
    }
}
