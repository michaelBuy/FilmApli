using FilmApli.Models;
using FilmApli_BLL.Models;

namespace FilmApli.Mapper
{
    public static class Mapper_Genre_Client
    {
        public static Genre_C ToClient(this Genre_BLL genre)
        {
            return new Genre_C()
            {
                Id = genre.Id,
                Nom_Genre = genre.Nom_Genre
            };
        }

        public static Genre_BLL ToBll(this Genre_C genre)
        {
            return new Genre_BLL()
            {
                Id = genre.Id,
                Nom_Genre = genre.Nom_Genre
            };
        }
    }
}
