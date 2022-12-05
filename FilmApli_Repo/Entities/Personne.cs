using FilmApli_Repo.Interfaces;

namespace FilmApli_Repo.Entities
{
    public class Personne : IEntity<int>
    {
        public int Id { get; set; }
        public string? Nom { get; set; }
        public string? Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string? Nationalite { get; set; }
    }
}
