using FilmApli.Models;
using FilmApli_BLL.Models;

namespace FilmApli.Mapper
{
    public static class Mapper_Personne_Client
    {
        public static Personne_C ToClient(this Personne_BLL personne)
        {
            return new Personne_C()
            {
                Id = personne.Id,
                Nom = personne.Nom,
                Prenom = personne.Prenom,
                DateNaissance = personne.DateNaissance,
                Nationalite = personne.Nationalite
            };
        }

        public static Personne_BLL ToBLL(this Personne_C personne)
        {
            return new Personne_BLL()
            {
                Id = personne.Id,
                Nom = personne.Nom,
                Prenom = personne.Prenom,
                DateNaissance = personne.DateNaissance,
                Nationalite = personne.Nationalite
            };
        }
    }
}
