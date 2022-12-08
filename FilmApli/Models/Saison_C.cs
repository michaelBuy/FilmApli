using FilmApli_Repo.Entities;
using FilmApli_Repo.Interfaces;

namespace FilmApli.Models
{
    public class Saison_C : IEntity<int>
    {
        public int Id { get; set; }
        public Serie? Id_Serie { get; set; }
        public int Num_Saison { get; set; }
        public string? Nom_Saison { get; set; }
    }
}
