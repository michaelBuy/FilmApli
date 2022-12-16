using FilmApli_BLL.Models;
using FilmApli_Repo.Entities;

namespace FilmApli_BLL.Mapper
{
    public static class Mapper_Film_Bll
    {
        public static Film_BLL ToRepo(this Film film_repo)
        {
            return new Film_BLL
            {
                Id = film_repo.Id,
                Titre = film_repo.Titre,
                DateSortie = film_repo.DateSortie,
                Duree = film_repo.Duree,
                Origine = film_repo.Origine,
                Synopsis_Film = film_repo.Synopsis_Film,
                Img_Url = film_repo.Img_Url
            };
        }

        public static Film ToBll(this Film_BLL film_bll)
        {
            return new Film
            {
                Id = film_bll.Id,
                Titre = film_bll.Titre,
                DateSortie = film_bll.DateSortie,
                Duree = film_bll.Duree,
                Origine = film_bll.Origine,
                Synopsis_Film = film_bll.Synopsis_Film,                
                Img_Url = film_bll.Img_Url
            };
        }
    }
}
