using Livre_Project.Models;

namespace Livre_Project.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Livres
                if (!context.Livres.Any())
                {
                    context.Livres.AddRange(new List<Livre>()
                   {
                       new Livre()
                       {
                             ImgUrl = "https://hackr.io/blog/uploads/images/clean-code-a-handbook-of-agile-software-craftsmanship-1st-edition.jpg",
                             Titre = "Clean Code",
                             Description = "Un livre pour ecrire du code lisible",
                             Auteur = "Robert C. Martin"
                       },

                         new Livre()
                       {
                             ImgUrl = "https://hackr.io/blog/uploads/images/clean-code-a-handbook-of-agile-software-craftsmanship-1st-edition.jpg",
                             Titre = "Clean Code",
                             Description = "Un livre pour ecrire du code lisible",
                             Auteur = "Robert C. Martin"
                       },

                           new Livre()
                       {
                             ImgUrl = "https://hackr.io/blog/uploads/images/clean-code-a-handbook-of-agile-software-craftsmanship-1st-edition.jpg",
                             Titre = "Clean Code",
                             Description = "Un livre pour ecrire du code lisible",
                             Auteur = "Robert C. Martin"
                       },

                             new Livre()
                       {
                             ImgUrl = "https://hackr.io/blog/uploads/images/clean-code-a-handbook-of-agile-software-craftsmanship-1st-edition.jpg",
                             Titre = "Clean Code",
                             Description = "Un livre pour ecrire du code lisible",
                             Auteur = "Robert C. Martin"
                       },

                               new Livre()
                       {
                             ImgUrl = "https://hackr.io/blog/uploads/images/clean-code-a-handbook-of-agile-software-craftsmanship-1st-edition.jpg",
                             Titre = "Clean Code",
                             Description = "Un livre pour ecrire du code lisible",
                             Auteur = "Robert C. Martin"
                        }
                   });

                    context.SaveChanges();
                }

                //Utilisateurs
                if (!context.Utilisateurs.Any())
                {
                    context.Utilisateurs.AddRange(new List<Utilisateur>()
                    {
                        new Utilisateur()
                        {
                            Email = "james@gmail.com",
                            Password= "password"
                        },

                        new Utilisateur()
                        {
                            Email = "joel@gmail.com",
                            Password= "password"
                        },

                        new Utilisateur()
                        {
                            Email = "cadet@gmail.com",
                            Password= "password"
                        },

                        new Utilisateur()
                        {
                            Email = "julien@gmail.com",
                            Password= "password"
                        },

                        new Utilisateur()
                        {
                            Email = "joseph@gmail.com",
                            Password= "password"
                        }

                    });
                    context.SaveChanges();
                }
                //Livres_Utilisateurs
                if (!context.Livres_Utilisateurs.Any())
                {
                    context.Livres_Utilisateurs.AddRange(new List<Livre_Utilisateur>()
                    {
                        new Livre_Utilisateur()
                        {
                            UtilisateurId = 2,
                            LivreId = 2
                        },

                        new Livre_Utilisateur()
                        {
                            UtilisateurId = 2,
                            LivreId = 4
                        },

                        new Livre_Utilisateur()
                        {
                            UtilisateurId = 4,
                            LivreId = 2
                        },

                        new Livre_Utilisateur()
                        {
                            UtilisateurId = 5,
                            LivreId = 1
                        },

                        new Livre_Utilisateur()
                        {
                            UtilisateurId = 3,
                            LivreId = 5
                        },
                    });

                    context.SaveChanges();
                }
            }
        }
    }
}
