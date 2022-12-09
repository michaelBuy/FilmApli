using FilmApli_Repo.Interfaces;

namespace FilmApli.Models
{
    public class Fonction_C : IEntity<int>
    {
        public int Id { get; set; }
        public string? Nom_Fonction { get; set; }
    }
}
