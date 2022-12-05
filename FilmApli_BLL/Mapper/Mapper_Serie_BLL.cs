using FilmApli_BLL.Models;
using FilmApli_Repo.Entities;

namespace FilmApli_BLL.Mapper
{
    public static class Mapper_Serie_BLL
    {
        public static Serie_BLL ToRepo(this Serie serie)
        {
            return new Serie_BLL
            {
                Id = serie.Id,
                Nom_Serie = serie.Nom_Serie,
                Duree_Serie = serie.Duree_Serie,
                DateSortie_Serie  = serie.DateSortie_Serie,
                Synopsis_Serie = serie.Synopsis_Serie,
                Origine_Serie = serie.Origine_Serie
            };
        }
        public static Serie ToBLL(this Serie_BLL serie)
        {
            return new Serie
            {
                Id = serie.Id,
                Nom_Serie = serie.Nom_Serie,
                Duree_Serie = serie.Duree_Serie,
                DateSortie_Serie = serie.DateSortie_Serie,
                Synopsis_Serie = serie.Synopsis_Serie,
                Origine_Serie = serie.Origine_Serie
            };
        }
    }
}
