using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sistema_Alquiler_Cancha__Wally.Models;

namespace Sistema_Alquiler_Cancha__Wally.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cancha> Canchas { get; set; }
        public DbSet<Alquiler> Alquilers { get; set; }
    }
}
