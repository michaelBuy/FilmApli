using FilmApli.Models;
using FilmApli_BLL.Models;

namespace FilmApli.Mapper
{
    public static class Mapper_Fonction_Client
    {
        public static Fonction_C ToClient(this Fonction_BLL fonction)
        {
            return new Fonction_C
            {
                Id = fonction.Id,
                Nom_Fonction = fonction.Nom_Fonction
            };
        }

        public static Fonction_BLL ToBll(this Fonction_C fonction)
        {
            return new Fonction_BLL
            {
                Id = fonction.Id,
                Nom_Fonction = fonction.Nom_Fonction
            };
        }
    }
}
