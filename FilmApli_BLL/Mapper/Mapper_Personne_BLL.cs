using FilmApli_BLL.Models;
using FilmApli_Repo.Entities;

namespace FilmApli_BLL.Mapper
{
    public static class Mapper_Personne_BLL
    {
        public static Personne_BLL ToRepo(this Personne personne_repo)
        {
            return new Personne_BLL
            {
                Id = personne_repo.Id,
                Nom = personne_repo.Nom,
                Prenom = personne_repo.Prenom,
                DateNaissance = personne_repo.DateNaissance,
                Nationalite = personne_repo.Nationalite
            };
        }
        public static Personne ToBLL(this Personne_BLL personne_BLL)
        {
            return new Personne
            {
                Id = personne_BLL.Id,
                Nom = personne_BLL.Nom,
                Prenom = personne_BLL.Prenom,
                DateNaissance = personne_BLL.DateNaissance,
                Nationalite = personne_BLL.Nationalite
            };
        }
    }
}
