using FilmApli_Repo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmApli_Repo.Entities
{
    public class Episode : IEntity<int>
    {
        public int Id { get ; set ; }
        public int Numero_Episode { get; set; }
        public DateTime Date_Diffusion { get; set; }
        public string? Titre_Episode { get; set; }
        public string? Synopsis_Episode { get; set; }
        public Saison? Id_Saison  { get; set; }
    }
}
