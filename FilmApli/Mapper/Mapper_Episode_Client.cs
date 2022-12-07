using FilmApli.Models;
using FilmApli_BLL.Models;

namespace FilmApli.Mapper
{
    public static class Mapper_Episode_Client
    {
        public static Episode_C ToClient(this Episode_BLL episode)
        {
            return new Episode_C()
            {
                Id = episode.Id,
                Numero_Episode = episode.Numero_Episode,
                Date_Diffusion = episode.Date_Diffusion,
                Titre_Episode = episode.Titre_Episode,
                Synopsis_Episode = episode.Synopsis_Episode,
                Id_Saison = episode.Id_Saison
            };
        }
        public static Episode_BLL ToBLL(this Episode_C episode)
        {
            return new Episode_BLL()
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
