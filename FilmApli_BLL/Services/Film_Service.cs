using FilmApli_BLL.Interfaces;
using FilmApli_BLL.Models;
using FilmApli_BLL.Mapper;
using FilmApli_Repo.Repositories;


namespace FilmApli_BLL.Services
{
    public class Film_Service : IFilmService
    {
        private FilmRepo? _filmRepo;

        public Film_Service()
        {
            _filmRepo = new FilmRepo();
        }

        public bool Delete(Film_BLL id)
        {
            return _filmRepo!.Delete(id.ToBll());
        }

        public Film_BLL Get(int id)
        {
            return _filmRepo!.Get(id).ToRepo();
        }

        public IEnumerable<Film_BLL> GetAll()
        {
            return _filmRepo!.GetAll().Select(x => x.ToRepo());
        }

        public int Insert(Film_BLL entity)
        {
            return _filmRepo!.Insert(entity.ToBll());
        }

        public bool Update(Film_BLL data)
        {
            return _filmRepo!.Update(data.ToBll()); 
        }
    }
}
