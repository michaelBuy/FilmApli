using FilmApli.Models;
using FilmApli_BLL.Models;

namespace FilmApli.Mapper
{
    public static class Mapper_Saison_Client
    {
        public static Saison_C ToClient(this Saison_BLL saison)
        {
            return new Saison_C
            {
                Id = saison.Id,
                Id_Serie = saison.Id_Serie,
                Num_Saison = saison.Num_Saison,
                Nom_Saison = saison.Nom_Saison
            };
        }

        public static Saison_BLL ToBll(this Saison_C saison)
        {
            return new Saison_BLL
            {
                Id = saison.Id,
                Id_Serie = saison.Id_Serie,
                Num_Saison = saison.Num_Saison,
                Nom_Saison = saison.Nom_Saison
            };
        }
    }
}
