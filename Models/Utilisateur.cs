using System.ComponentModel.DataAnnotations;

namespace Livre_Project.Models
{
    public class Utilisateur
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }


        public List<Livre_Utilisateur> Livres_Utilisateurs { get; set; }
    }
}
