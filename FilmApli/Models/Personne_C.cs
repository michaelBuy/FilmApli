using FilmApli_Repo.Interfaces;

namespace FilmApli.Models
{
    public class Personne_C : IEntity<int>
    {
        public int Id { get; set; }
        public string? Nom { get; set; }
        public string? Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string? Nationalite { get; set; }
    }
}
