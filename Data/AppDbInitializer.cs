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
                             Description = "La programmation consiste à polir le métier avec des années d’essais et d’erreurs. J’aimerais qu’il y ait un moyen de vous sauver de tout le travail acharné en apprenant des erreurs des autres programmeurs? Heureusement, il existe, et il est connu dans le monde entier sous le nom de Clean Code: A Handbook of Agile Software Craftsmanship book du légendaire Oncle Bob.",
                             Auteur = "Robert C. Martin"
                       },

                         new Livre()
                       {
                             ImgUrl = "https://hackr.io/blog/uploads/images/introduction-to-algorithms-eastern-economy-edition.jpg",
                             Titre = "Introduction aux algorithmes",
                             Description = "La programmation consiste à polir le métier avec des années d’essais et d’erreurs. J’aimerais qu’il y ait un moyen de vous sauver de tout le travail acharné en apprenant des erreurs des autres programmeurs? Heureusement, il existe, et il est connu dans le monde entier sous le nom de Clean Code: A Handbook of Agile Software Craftsmanship book du légendaire Oncle Bob.",
                             Auteur = "Thomas H. Cormen, Charles E. Leiserson, Ronald L. Rivest, Clifford Stein"
                       },

                           new Livre()
                       {
                             ImgUrl = "https://hackr.io/blog/uploads/images/clean-code-a-handbook-of-agile-software-craftsmanship-1st-edition.jpg",
                             Titre = "Structure et interprétation",
                             Description = "Un livre pour ecrire du code lisible",
                             Auteur = "Harold Abelson, Gerald Jay Sussman, Julie Sussman"
                       },

                             new Livre()
                       {
                             ImgUrl = "https://hackr.io/blog/uploads/images/clean-code-a-handbook-of-agile-software-craftsmanship-1st-edition.jpg",
                             Titre = "The Clean Coder",
                             Description = "Structure et interprétation des programmes d’ordinateur (SICP)",
                             Auteur = "Robert C. Martin"
                       },

                               new Livre()
                       {
                             ImgUrl = "https://hackr.io/blog/uploads/images/clean-code-a-handbook-of-agile-software-craftsmanship-1st-edition.jpg",
                             Titre = "Code Complete",
                             Description = "ous voulez savoir comment écrire du code robuste quelle que soit l’architecture d’un langage de programmation ? Ensuite, envisagez de lire le Code complet: Un manuel pratique de la construction logicielle. Il couvre de manière exhaustive tous les aspects de la structure d’un bon code.",
                             Auteur = "Steve McConnell"
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
