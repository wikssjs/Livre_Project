using Livre_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Livre_Project.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Livre_Utilisateur>().HasKey(al => new
            {
                al.UtilisateurId,
                al.LivreId
            });

            modelBuilder.Entity<Livre_Utilisateur>().HasOne(m => m.Livre).WithMany(al => al.Livre_Utilisateur)
                .HasForeignKey(m => m.LivreId);

            modelBuilder.Entity<Livre_Utilisateur>().HasOne(m => m.Utilisateur).WithMany(al => al.Livres_Utilisateurs)
                .HasForeignKey(m => m.UtilisateurId);


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Livre> Livres { get; set; }
        public DbSet<Livre_Utilisateur> Livres_Utilisateurs { get; set; }
    }
}
