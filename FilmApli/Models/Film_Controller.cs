using FilmApli_Repo.Interfaces;

namespace FilmApli.Models
{
    public class Film_C : IEntity<int>
    {
        public int Id { get; set; }
        public string? Titre { get; set; }
        public DateTime? DateSortie { get; set; }
        public string? Duree { get; set; }
        public string? Origine { get; set; }
        public string? Synopsis_Film { get; set; }
    }
}
