using FilmApli.Models;
using FilmApli_BLL.Models;

namespace FilmApli.Mapper
{
    public static class Mapper_Serie_Client
    {
        public static Serie_C ToClient(this Serie_BLL serie)
        {
            return new Serie_C()
            {
                Id = serie.Id,
                Nom_Serie = serie.Nom_Serie,
                Duree_Serie = serie.Duree_Serie,
                DateSortie_Serie = serie.DateSortie_Serie,
                Synopsis_Serie = serie.Synopsis_Serie,
                Origine_Serie = serie.Origine_Serie
            };
        }
        public static Serie_BLL ToBLL(this Serie_C serie)
        {
            return new Serie_BLL()
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
