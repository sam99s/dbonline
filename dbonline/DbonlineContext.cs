using dbonline.Models;
using Microsoft.EntityFrameworkCore;

namespace dbonline
{
    public class DbonlineContext : DbContext
    {
        public DbSet<Personaje> Personajes { get; set; }
        public DbSet<PersonajeForma> PersonajesForma { get; set; }
        public DbSet<Raza> Razas { get; set; }
        public DbSet<Saga> Sagas { get; set; }
        public DbSet<Universo> Universos { get; set; }
        public DbSet<Imagen> Imagenes { get; set; }
        public DbSet<Batalla> Batallas { get; set; }

        public DbonlineContext(DbContextOptions<DbonlineContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personaje>(p =>
            {
                p.ToTable("Personaje");
                p.HasKey(p => p.PersonajeId);
                p.Property(p => p.Nombre).IsRequired().HasMaxLength(100);
                p.HasOne(p => p.Saga).WithMany(s => s.Personajes).HasForeignKey(p => p.SagaId).OnDelete(DeleteBehavior.Restrict);
                p.HasOne(p => p.Raza).WithMany(r => r.Personajes).HasForeignKey(p => p.RazaId).OnDelete(DeleteBehavior.Restrict);
                p.HasOne(p => p.Universo).WithMany(u => u.Personajes).HasForeignKey(p => p.UniversoId).OnDelete(DeleteBehavior.Restrict);
                p.HasOne(p => p.Imagen).WithMany(i => i.Personajes).HasForeignKey(p => p.ImagenId).OnDelete(DeleteBehavior.Restrict);
                p.HasOne(p => p.Serie).WithMany(s => s.Personajes).HasForeignKey(p => p.SerieId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<PersonajeForma>(pf =>
            {
                pf.ToTable("PersonajesForma");
                pf.HasKey(pf => pf.PFId);
                pf.Property(pf => pf.Nombre).IsRequired().HasMaxLength(100);
                pf.HasOne(pf => pf.Personaje).WithMany(p => p.transformaciones).HasForeignKey(pf => pf.PersonajeId).OnDelete(DeleteBehavior.Restrict);
                pf.HasOne(pf => pf.Saga).WithMany(s => s.transformaciones).HasForeignKey(p => p.SagaId).OnDelete(DeleteBehavior.Restrict);
                pf.HasOne(pf => pf.Raza).WithMany(r => r.transformaciones).HasForeignKey(p => p.RazaId).OnDelete(DeleteBehavior.Restrict);
                pf.HasOne(pf => pf.Universo).WithMany(u => u.transformaciones).HasForeignKey(p => p.UniversoId).OnDelete(DeleteBehavior.Restrict);
                pf.HasOne(pf => pf.Imagen).WithMany(i => i.transformaciones).HasForeignKey(p => p.ImagenId).OnDelete(DeleteBehavior.Restrict);
                pf.HasOne(pf => pf.Serie).WithMany(s => s.transformaciones).HasForeignKey(p => p.SerieId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Raza>(r =>
            {
                r.ToTable("Raza");
                r.HasKey(r => r.RazaId);
                r.Property(r => r.RazaNombre).IsRequired().HasMaxLength(50);
            });

            modelBuilder.Entity<Serie>(s =>
            {
                s.ToTable("Serie");
                s.HasKey(s => s.SerieId);
                s.Property(s => s.SerieNombre).IsRequired().HasMaxLength(100);
            });

            modelBuilder.Entity<Saga>(s =>
            {
                s.ToTable("Saga");
                s.HasKey(s => s.SagaId);
                s.HasOne(s => s.Serie).WithMany(s => s.Sagas).HasForeignKey(s => s.SerieId).OnDelete(DeleteBehavior.Restrict);
                s.Property(s => s.SagaNombre).IsRequired().HasMaxLength(100);
                s.Property(s => s.Año).IsRequired(false).HasMaxLength(100);
            });

            modelBuilder.Entity<Universo>(u =>
            {
                u.ToTable("Universo");
                u.HasKey(u => u.UniversoId);
                u.Property(u => u.UniversoNombre).IsRequired().HasMaxLength(50);
            });

            modelBuilder.Entity<Batalla>(b =>
            {
                b.ToTable("Batalla");
                b.HasKey(b => b.BatallaId);
                b.Property(b => b.NombreBatalla).IsRequired().HasMaxLength(100);
                b.Property(b => b.url).IsRequired();
            });

            modelBuilder.Entity<Imagen>(i =>
            {
                i.ToTable("Imagen");
                i.HasKey(i => i.ImagenId);
                i.Property(i => i.url).IsRequired().HasMaxLength(255);
                i.HasOne(i => i.PersonajesForma).WithMany(pf => pf.Imagenes).HasForeignKey(i => i.PFId).OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}
