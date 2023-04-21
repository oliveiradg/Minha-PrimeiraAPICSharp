using Microsoft.EntityFrameworkCore;
using MinhaApi.models;

namespace MinhaApi.Data
{
    public class SistemaTarefasDBContext : DbContext
    {
        public SistemaTarefasDBContext(DbContextOptions<SistemaTarefasDBContext> options) 
            : base(options) 
        { 

        }

        public DbSet<usuarioModel> Usuarios { get; set; }
    }
}
