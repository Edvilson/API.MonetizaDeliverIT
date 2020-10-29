using Microsoft.EntityFrameworkCore;
using Monetiza.Models;

namespace Monetiza.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }
        public DbSet<Conta> Contas { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

    }
}
