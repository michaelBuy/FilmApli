using FilmApli.Models;
using FilmApli_BLL.Models;

namespace FilmApli.Mapper
{
    public static class Mapper_Film_Client
    {
        public static Film_C ToClient(this Film_BLL film_bll)
        {
            return new Film_C()
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

        public static Film_BLL ToBLL(this Film_C film_controller)
        {
            return new Film_BLL()
            {
                Id = film_controller.Id,
                Titre = film_controller.Titre,
                DateSortie = film_controller.DateSortie,
                Duree = film_controller.Duree,
                Origine = film_controller.Origine,
                Synopsis_Film = film_controller.Synopsis_Film,
                Img_Url= film_controller.Img_Url
            };
        }
    }
}
