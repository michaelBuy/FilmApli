using FilmApli_BLL.Interfaces;
using FilmApli_BLL.Models;
using FilmApli_Repo.Repositories;
using FilmApli_BLL.Mapper;

namespace FilmApli_BLL.Services
{
    public class Personne_Service : IPersonneService
    {
        private PersonneRepo? _personneRepo;

        public Personne_Service()
        {
            _personneRepo = new PersonneRepo();
        }

        public bool Delete(Personne_BLL id)
        {
            return _personneRepo!.Delete(id.ToBLL());
        }

        public Personne_BLL Get(int id)
        {
            return _personneRepo!.Get(id).ToRepo();
        }

        public IEnumerable<Personne_BLL> GetAll()
        {
            return _personneRepo!.GetAll().Select(x => x.ToRepo());
        }

        public int Insert(Personne_BLL entity)
        {
            return _personneRepo!.Insert(entity.ToBLL());
        }

        public bool Update(Personne_BLL data)
        {
            return _personneRepo!.Update(data.ToBLL());
        }
    }
}
