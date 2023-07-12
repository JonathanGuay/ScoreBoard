using Microsoft.EntityFrameworkCore;

namespace ScoreBoard.Models
{
    public class dbJoueurRep : IJoueurRepository
    {
        private readonly ScoreBoardDbContext _scoreboardDbContext;

        public dbJoueurRep(ScoreBoardDbContext motoDbContext)
        {
            _scoreboardDbContext = motoDbContext;
        }

        public List<Joueur> ListeJoueurs 
        { 
            get { return _scoreboardDbContext.Joueurs.Include(g => g.Jeux).OrderBy(g => g.Nom).ToList(); }
        }

        public Joueur? GetJoueur(int id)
        {
            throw new NotImplementedException();
        }

        public void Modifier(Joueur joueur)
        {
            throw new NotImplementedException();
        }

        public void Supprimer(int id)
        {
            throw new NotImplementedException();
        }
    }
}
