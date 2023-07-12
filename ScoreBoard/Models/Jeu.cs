using System.ComponentModel.DataAnnotations;

namespace ScoreBoard.Models
{
    public class Jeu
    {
        [Required(ErrorMessage = "L'id est obligatoire")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Le nom est obligatoire")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "La date de sortie est obligatoire")]
        public DateTime DateSortie { get; set; }

        [Required(ErrorMessage = "La description est obligatoire")]
        public string Description { get; set; }

        [Required(ErrorMessage = "L'id du joueur est obligatoire")]
        public int JoueurId { get; set; }

        [Required(ErrorMessage = "Le joueur est obligatoire")]
        public Joueur Joueur { get; set; }

        [RegularExpression(@"^{0-100}$",
        ErrorMessage = "Le score doit être compris entre de 0 et 100")]
        [Required(ErrorMessage = "Le score du joueur est obligatoire")]
        public int ScoreJoueur { get; set; }

        [Required(ErrorMessage = "La date d'enregistrement est obligatoire")]
        public DateTime DateEnregistrement { get; set; }
    }
}
