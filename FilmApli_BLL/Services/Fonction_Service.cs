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
    public class Fonction_Service : IFonctionService
    {
        private readonly FonctionRepo? _fonctionRepo;

        public Fonction_Service()
        {
            _fonctionRepo = new FonctionRepo();
        }

        public bool Delete(Fonction_BLL id)
        {
            return _fonctionRepo!.Delete(id.ToBll());
        }

        public Fonction_BLL Get(int id)
        {
            return _fonctionRepo!.Get(id).ToRepo();
        }

        public IEnumerable<Fonction_BLL> GetAll()
        {
            return _fonctionRepo!.GetAll().Select(x => x.ToRepo());
        }

        public int Insert(Fonction_BLL entity)
        {
            return _fonctionRepo!.Insert(entity.ToBll());
        }

        public bool Update(Fonction_BLL data)
        {
            return _fonctionRepo!.Update(data.ToBll());
        }
    }
}
