using FilmApli_Repo.Interfaces;

namespace FilmApli_Repo.Entities
{
    public class Serie : IEntity<int>
    {
        public int Id { get; set; }
        public string? Nom_Serie { get; set; }
        public string? Duree_Serie { get; set; }
        public DateTime DateSortie_Serie { get; set; }
        public string? Synopsis_Serie { get; set; }
        public string? Origine_Serie { get; set; }
    }
}
