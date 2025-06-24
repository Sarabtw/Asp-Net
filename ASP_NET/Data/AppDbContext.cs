using Microsoft.EntityFrameworkCore;
using TarefasApiNet8.Models;

namespace TarefasApiNet8.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Tarefa> Tarefas { get; set; } = null!;
    }
}
