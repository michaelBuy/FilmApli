using FilmApli_BLL.Interfaces;
using FilmApli_BLL.Mapper;
using FilmApli_BLL.Models;
using FilmApli_Repo.Repositories;


namespace FilmApli_BLL.Services
{
    public class Episode_Service : IEpisodeService
    {
        private EpisodeRepo? _episodeRepo;

        public Episode_Service()
        {
            _episodeRepo = new EpisodeRepo();
        }

        public bool Delete(Episode_BLL id)
        {
            return _episodeRepo!.Delete(id.ToBLL());
        }

        public Episode_BLL Get(int id)
        {
            return _episodeRepo!.Get(id).ToRepo();
        }

        public IEnumerable<Episode_BLL> GetAll()
        {
            return _episodeRepo!.GetAll().Select(x => x.ToRepo()); // Ajouter le lien avec Saison
        }

        public int Insert(Episode_BLL entity)
        {
            return _episodeRepo!.Insert(entity.ToBLL());
        }

        public bool Update(Episode_BLL data)
        {
            return _episodeRepo!.Update(data.ToBLL());
        }
    }
}
