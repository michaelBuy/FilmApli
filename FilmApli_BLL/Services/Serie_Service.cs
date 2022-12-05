using FilmApli_BLL.Interfaces;
using FilmApli_BLL.Mapper;
using FilmApli_BLL.Models;
using FilmApli_Repo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmApli_BLL.Services
{
    public class Serie_Service : ISerieService
    {
        private SerieRepo? _serieRepo;
        public Serie_Service()
        {
            _serieRepo = new SerieRepo();
        }

        public bool Delete(Serie_BLL id)
        {
            return _serieRepo!.Delete(id.ToBLL());
        }

        public Serie_BLL Get(int id)
        {
            return _serieRepo!.Get(id).ToRepo();
        }

        public IEnumerable<Serie_BLL> GetAll()
        {
            return _serieRepo!.GetAll().Select(x => x.ToRepo());
        }

        public int Insert(Serie_BLL entity)
        {
            return _serieRepo!.Insert(entity.ToBLL());
        }

        public bool Update(Serie_BLL data)
        {
            return _serieRepo!.Update(data.ToBLL());
        }
    }
}
