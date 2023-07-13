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
            return _scoreboardDbContext.Joueurs.Include(g => g.Jeux).FirstOrDefault(g => g.Id == id);
        }

        public void Modifier(Joueur joueur)
        {
            _scoreboardDbContext.Joueurs.Update(joueur);
            _scoreboardDbContext.SaveChanges();
        }

        public void Supprimer(int id)
        {
            Joueur joueur = _scoreboardDbContext.Joueurs.FirstOrDefault(g => g.Id == id);
            if (joueur != null)
            {
                _scoreboardDbContext.Joueurs.Remove(GetJoueur(id));
                _scoreboardDbContext.SaveChanges();
            }
        }
    }
}
