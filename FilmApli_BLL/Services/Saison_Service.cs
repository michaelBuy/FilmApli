using FilmApli_BLL.Interfaces;
using FilmApli_BLL.Mapper;
using FilmApli_BLL.Models;
using FilmApli_Repo.Repositories;


namespace FilmApli_BLL.Services
{
    public class Saison_Service : ISaisonService
    {
        private SaisonRepo? _saison;

        public Saison_Service()
        {
            _saison = new SaisonRepo();
        }

        public bool Delete(Saison_BLL id)
        {
            return _saison!.Delete(id.ToBLL());
        }

        public Saison_BLL Get(int id)
        {
            return _saison!.Get(id).ToRepo();
        }

        public IEnumerable<Saison_BLL> GetAll()
        {
            return _saison!.GetAll().Select(x => x.ToRepo());
        }

        public int Insert(Saison_BLL entity)
        {
            return _saison!.Insert(entity.ToBLL());
        }

        public bool Update(Saison_BLL data)
        {
            return _saison!.Update(data.ToBLL());
        }
    }
}
