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
                             Description = "La programmation consiste à polir le métier avec des années d’essais et d’erreurs.",
                             Auteur = "Robert C. Martin"
                       },

                         new Livre()
                       {
                             ImgUrl = "https://hackr.io/blog/uploads/images/introduction-to-algorithms-eastern-economy-edition.jpg",
                             Titre = "Introduction aux algorithmes",
                             Description = "Le nom du livre est explicite. C’est ce que le titre suggère, c’est-à-dire Introduction aux algorithmes.",
                             Auteur = "Thomas H. Cormen"
                       },

                           new Livre()
                       {
                             ImgUrl = "https://hackr.io/blog/uploads/images/structure-and-interpretation-of-computer-programs-2nd-edition-mit-electrical-engineering-and-computer-science1.jpg",
                             Titre = "Structure et interprétation",
                             Description = "a structure et l’interprétation des programmes informatiques, alias SICP est parmi les meilleurs livres pourapprendre les bases de la programmation. ",
                             Auteur = "Harold Abelson"
                       },

                             new Livre()
                       {
                             ImgUrl = "https://hackr.io/blog/uploads/images/the-clean-coder.jpg",
                             Titre = "The Clean Coder",
                             Description = "Compilé par l’ingénieur logiciel chevronné et auteur Robert C. Martin alias Oncle Bob, le livre The Clean Coder couvre les pratiques, les techniques et les outils du véritable savoir-faire logiciel. ",
                             Auteur = "Robert C. Martin"
                       },

                               new Livre()
                       {
                             ImgUrl = "https://hackr.io/blog/uploads/images/code-caomplete.jpg",
                             Titre = "Code Complete",
                             Description = "Vous voulez savoir comment écrire du code robuste quelle que soit l’architecture d’un langage de programmation ? Ensuite, envisagez de lire le Code complet: Un manuel pratique de la construction logicielle. Il couvre de manière exhaustive tous les aspects de la structure d’un bon code.",
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
