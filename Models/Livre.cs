using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Livre_Project.Models
{
    public class Livre
    {
        [Key]
        public int Id { get; set; }

        [DisallowNull]
        [Display(Name ="Url")]
        public string ImgUrl { get; set; }

        [DisallowNull]
        [Display(Name ="Titre")]
        public string Titre { get; set; }

        [DisallowNull]
        [Display(Name ="Description")]
        public string Description { get; set; }

        [DisallowNull]
        [Display(Name ="Auteur")]
        public string Auteur { get; set; }


        public List<Livre_Utilisateur> Livre_Utilisateur { get; set; }
    }
}
