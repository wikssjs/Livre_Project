using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Livre_Project.Models
{
    public class Livre
    {
        [Key]
        public int Id { get; set; }

        [DisallowNull]
        public string ImgUrl { get; set; }

        [DisallowNull]
        public string Titre { get; set; }

        [DisallowNull]
        public string Description { get; set; }

        [DisallowNull]
        public string Auteur { get; set; }


        public List<Livre_Utilisateur> Livre_Utilisateur { get; set; }
    }
}
