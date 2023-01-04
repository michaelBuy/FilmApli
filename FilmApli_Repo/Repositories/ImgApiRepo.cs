using FilmApli_DAL;
using FilmApli_Repo.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmApli_Repo.Repositories
{
    public class ImgApiRepo : BasicRepository.BasicRepo<int, imgApi>
    {
        public ImgApiRepo() : base("imgApi", "Id")
        {
        }
        protected override imgApi Convert(IDataRecord dtr)
        {
            return new imgApi
            {
                Id = (int)dtr["Id"],
                Id_Film = (int)dtr["Id_Film"],
                Id_Beta = (int)dtr["Id_Beta"]
            };
        }

        public override bool Delete(imgApi id)
        {
            Command cmd = new Command("P_imgApi_Delete", true);
            cmd.AddParameter("@Id", id.Id);
            return ConnectionString?.ExecuteNonQuery(cmd) == 1;
        }

        public override int Insert(imgApi entity)
        {
            Command cmd = new Command("P_imgApi_Insert", true);
            cmd.AddParameter("@Id_Film", entity.Id_Film);
            cmd.AddParameter("@Id_Beta", entity.Id_Beta);
            return ConnectionString!.ExecuteNonQuery(cmd);
        }

        public override bool Update(imgApi data)
        {
            Command cmd = new Command("P_imgApi_Update", true);
            cmd.AddParameter("@Id", data.Id);
            cmd.AddParameter("@Id_Film", data.Id_Film);
            cmd.AddParameter("@Id_Beta", data.Id_Beta);
            return ConnectionString!.ExecuteNonQuery(cmd) == 1;
        }

    }
}
