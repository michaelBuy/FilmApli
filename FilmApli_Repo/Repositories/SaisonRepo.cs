using FilmApli_Repo.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmApli_Repo.Repositories
{
    public class SaisonRepo : BasicRepository.BasicRepo<int, Saison>
    {
        public SaisonRepo() : base("Saison", "Id_Saison")
        {
        }

        public override bool Delete(Saison id)
        {
            throw new NotImplementedException();
        }

        public override int Insert(Saison entity)
        {
            throw new NotImplementedException();
        }

        public override bool Update(Saison data)
        {
            throw new NotImplementedException();
        }

        protected override Saison Convert(IDataRecord dtr)
        {
            throw new NotImplementedException();
        }
    }
}
