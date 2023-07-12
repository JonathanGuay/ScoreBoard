using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ScoreBoard.Models
{
    public class ScoreBoardDbContext : DbContext
    {
        public ScoreBoardDbContext(DbContextOptions<ScoreBoardDbContext> options) : base(options)
        {

        }

        // Ajouter un Dbset pour chaque Tables
        public DbSet<Joueur> Joueurs { get; set; }
        public DbSet<Jeu> Jeux { get; set; }

    }
}
