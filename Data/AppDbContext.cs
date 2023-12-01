using Microsoft.EntityFrameworkCore;
using BlazorApp1.Models;
namespace BlazorApp1.Data
{
    public class AppDbContext : DbContext
    {

        public DbSet<Clinica> clinica { get; set; }

        public DbSet<Clinica> Id { get; set; }

        public DbSet<Clinica> medico { get; set; }

        public DbSet<Clinica> Paciente { get; set; }

        public DbSet<Clinica> Agendamento { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        
        
        }

    }
}
