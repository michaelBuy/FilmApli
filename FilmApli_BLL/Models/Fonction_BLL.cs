using FilmApli_Repo.Interfaces;


namespace FilmApli_BLL.Models
{
    public class Fonction_BLL : IEntity<int>
    {
        public int Id { get; set; }
        public string? Nom_Fonction { get; set; }
    }
}
