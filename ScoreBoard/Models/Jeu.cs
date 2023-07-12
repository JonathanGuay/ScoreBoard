using System.ComponentModel.DataAnnotations;

namespace ScoreBoard.Models
{
    public class Jeu
    {
        [Required(ErrorMessage = "L'id est obligatoire")]
        public int Id { get; set; }

        [Required(ErrorMessage = "L'id est obligatoire")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "L'id est obligatoire")]
        public DateTime DateSortie { get; set; }

        [Required(ErrorMessage = "L'id est obligatoire")]
        public string Description { get; set; }

        [Required(ErrorMessage = "L'id est obligatoire")]
        public int JoueurId { get; set; }

        [Required(ErrorMessage = "L'id est obligatoire")]
        public Joueur Joueur { get; set; }

        [Required(ErrorMessage = "L'id est obligatoire")]
        public int ScoreJoueur { get; set; }

        [Required(ErrorMessage = "L'id est obligatoire")]
        public DateTime DateEnregistrement { get; set; }
    }
}
