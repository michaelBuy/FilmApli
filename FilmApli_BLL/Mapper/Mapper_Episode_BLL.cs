using FilmApli_BLL.Models;
using FilmApli_Repo.Entities;


namespace FilmApli_BLL.Mapper
{
    public static class Mapper_Episode_BLL
    {
        public static Episode_BLL ToRepo(this Episode episode)
        {
            return new Episode_BLL
            {
                Id = episode.Id,
                Numero_Episode = episode.Numero_Episode,
                Date_Diffusion = episode.Date_Diffusion,
                Titre_Episode = episode.Titre_Episode,
                Synopsis_Episode = episode.Synopsis_Episode,
                Id_Saison = episode.Id_Saison
            };
        }

        public static Episode ToBLL(this Episode_BLL episode)
        {
            return new Episode
            {
                Id = episode.Id,
                Numero_Episode = episode.Numero_Episode,
                Date_Diffusion = episode.Date_Diffusion,
                Titre_Episode = episode.Titre_Episode,
                Synopsis_Episode = episode.Synopsis_Episode,
                Id_Saison = episode.Id_Saison
            };
        }
    }
}
