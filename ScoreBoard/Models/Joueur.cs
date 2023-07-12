using System.ComponentModel.DataAnnotations;

namespace ScoreBoard.Models
{
    public class Joueur
    {
        [Required(ErrorMessage = "L'id est obligatoire")]
        public int Id { get; set; }

        [RegularExpression(@"^.{2,20}$",
        ErrorMessage = "Le nom peut contenir de 2 à 20 caractères")]
        [Required(ErrorMessage = "Le nom est obligatoire")]
        public string Nom { get; set; }

        [RegularExpression(@"^.{2,20}$",
        ErrorMessage = "Le prénom peut contenir de 2 à 20 caractères")]
        [Required(ErrorMessage = "Le prénom est obligatoire")]
        public string Prenom { get; set; }

        [RegularExpression(@"^(?:[A-Z]){2,4}$",
        ErrorMessage = "Il faut de 2 à 4 majuscules")]
        public string? Equipe { get; set; }


        public string? Telephone { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Le courriel est obligatoire")]
        public string Courriel { get; set; }

        [Required(ErrorMessage = "Les jeux sont obligatoires")]
        public List<Jeu>? Jeux { get; set; }
    }
}
