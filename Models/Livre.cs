using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Livre_Project.Models
{
    public class Livre
    {
        [Key]
        public int Id { get; set; }


        [Display(Name ="Url")]
        [StringLength(200,MinimumLength =3,ErrorMessage ="url doit etre entre 3-200 carateres")]
        [Required(ErrorMessage ="Image url est requis")]
        public string ImgUrl { get; set; }


        [Display(Name ="Titre")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Le titre  doit etre entre 3-200 caracteres")]
        [Required(ErrorMessage = "Titre est requis")]
        public string Titre { get; set; }


        [Display(Name ="Auteur")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "L'auteur doit etre entre 3-200 caracteres")]
        [Required(ErrorMessage ="Auteur est requis")]
        public string Auteur { get; set; }


        [Display(Name ="Description")]
        [StringLength(1000, MinimumLength = 3, ErrorMessage = "La description doit etre entre 3-1000 caracteres")]
        [Required(ErrorMessage = "La description est requis")]
        public string Description { get; set; }


        public List<Livre_Utilisateur> Livre_Utilisateur { get; set; }
        public string disabled = "fill";
    }
}
