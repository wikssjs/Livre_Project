namespace Livre_Project.Models
{
    public class Livre_Utilisateur
    {
        public int UtilisateurId { get; set; }
        public Utilisateur Utilisateur { get; set; }

        public int LivreId { get; set; }
        public Livre Livre { get; set; }
    }
}
