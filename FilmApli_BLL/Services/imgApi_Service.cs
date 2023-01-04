using FilmApli_BLL.Interfaces;
using FilmApli_BLL.Mapper;
using FilmApli_BLL.Models;
using FilmApli_Repo.Repositories;


namespace FilmApli_BLL.Services
{
    public class imgApi_Service : IimgApiService
    {
        private ImgApiRepo? _imgApi;

        public imgApi_Service()
        {
            _imgApi = new ImgApiRepo();
        }

        public bool Delete(imgApi_BLL id)
        {
            return _imgApi!.Delete(id.ToBll());
        }

        public imgApi_BLL Get(int id)
        {
            return _imgApi!.Get(id).ToRepo();
        }

        public IEnumerable<imgApi_BLL> GetAll()
        {
            return _imgApi!.GetAll().Select(x => x.ToRepo());
        }

        public int Insert(imgApi_BLL entity)
        {
            return _imgApi!.Insert(entity.ToBll());
        }

        public bool Update(imgApi_BLL data)
        {
            return _imgApi!.Update(data.ToBll());
        }
    }
}
