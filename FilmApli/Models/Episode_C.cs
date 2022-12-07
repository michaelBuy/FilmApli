using FilmApli_Repo.Entities;
using FilmApli_Repo.Interfaces;

namespace FilmApli.Models
{
    public class Episode_C : IEntity<int>
    {
        public int Id { get; set; }
        public int Numero_Episode { get; set; }
        public DateTime Date_Diffusion { get; set; }
        public string? Titre_Episode { get; set; }
        public string? Synopsis_Episode { get; set; }
        public Saison? Id_Saison { get; set; }
    }
}
