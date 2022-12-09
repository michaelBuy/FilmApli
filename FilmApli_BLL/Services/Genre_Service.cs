using FilmApli_BLL.Interfaces;
using FilmApli_BLL.Mapper;
using FilmApli_BLL.Models;
using FilmApli_Repo.Repositories;


namespace FilmApli_BLL.Services
{
    public class Genre_Service : IGenreService
    {
        private GenreRepo _genreRepo;

        public Genre_Service()
        {
            _genreRepo = new GenreRepo();
        }

        public bool Delete(Genre_BLL id)
        {
            return _genreRepo.Delete(id.ToBLL());
        }

        public Genre_BLL Get(int id)
        {
            return _genreRepo.Get(id).ToRepo();
        }

        public IEnumerable<Genre_BLL> GetAll()
        {
            return _genreRepo.GetAll().Select(x => x.ToRepo());
        }

        public int Insert(Genre_BLL entity)
        {
            return _genreRepo.Insert(entity.ToBLL());
        }

        public bool Update(Genre_BLL data)
        {
            return _genreRepo.Update(data.ToBLL());
        }
    }
}
