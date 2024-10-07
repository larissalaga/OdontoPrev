using Microsoft.EntityFrameworkCore;
using WebApplicationOdontoPrev.Models;

namespace WebApplicationOdontoPrev.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        
        public DbSet<AnaliseRaioX> AnaliseRaioX { get; set; }
        public DbSet<Dentista> Dentista { get; set; }
        public DbSet<ExtratoPontos> ExtratoPontos { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Perguntas> Perguntas { get; set; }
        public DbSet<Plano> Plano { get; set; }
        public DbSet<RaioX> RaioX { get; set; }
        public DbSet<Respostas> Respostas { get; set; }

    }
    
}

