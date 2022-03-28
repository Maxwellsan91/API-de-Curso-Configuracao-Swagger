using curso.api.Bussines.Entities;
using curso.api.Infraestruture.Data.Maps;
using Microsoft.EntityFrameworkCore;

namespace curso.api.Infraestruture.Data
{
    public class CursoDbContext : DbContext
    {

        public CursoDbContext(DbContextOptions<CursoDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CursoMapping());
            modelBuilder.ApplyConfiguration(new UsuarioMapping());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Curso> Curso { get; set; }



    }
}
