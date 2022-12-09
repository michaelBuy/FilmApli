using FilmApli_Repo.Interfaces;

namespace FilmApli.Models
{
    public class Genre_C : IEntity<int>
    {
        public int Id { get; set; }
        public string? Nom_Genre { get; set; }
    }
}
