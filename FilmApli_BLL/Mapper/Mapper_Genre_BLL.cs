using FilmApli_BLL.Models;
using FilmApli_Repo.Entities;


namespace FilmApli_BLL.Mapper
{
    public static class Mapper_Genre_BLL
    {
        public static Genre_BLL ToRepo(this Genre genre)
        {
            return new Genre_BLL()
            {
                Id = genre.Id,
                Nom_Genre = genre.Nom_Genre!
            };
        }

        public static Genre ToBLL(this Genre_BLL genre)
        {
            return new Genre()
            {
                Id = genre.Id,
                Nom_Genre = genre.Nom_Genre!
            };
        }
    }
}
