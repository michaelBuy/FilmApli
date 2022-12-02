using FilmApli_Repo.Interfaces;

namespace FilmApli_Repo.Entities
{
    public class Film : IEntity<int>
    {
        public int Id { get ; set; }
        public string? Titre { get; set; }
        public DateTime? DateSortie { get; set; }
        public string? Duree { get; set; }
        public string? Origine { get; set; }    
        public string? Synopsis_Film { get; set; }
    }
}
