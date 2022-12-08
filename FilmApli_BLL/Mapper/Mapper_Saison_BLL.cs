using FilmApli_BLL.Models;
using FilmApli_Repo.Entities;


namespace FilmApli_BLL.Mapper
{
    public static class Mapper_Saison_BLL
    {
        public static Saison_BLL ToRepo(this Saison saison)
        {
            return new Saison_BLL
            {
                Id = saison.Id,
                Id_Serie = saison.Id_Serie,
                Nom_Saison = saison.Nom_Saison,
                Num_Saison = saison.Num_Saison
            };
        }

        public static Saison ToBLL(this Saison_BLL saison)
        {
            return new Saison
            {
                Id = saison.Id,
                Id_Serie = saison.Id_Serie,
                Nom_Saison = saison.Nom_Saison,
                Num_Saison = saison.Num_Saison
            };
        }
    }
}
