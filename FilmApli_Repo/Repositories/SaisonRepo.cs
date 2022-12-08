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
    public class SaisonRepo : BasicRepository.BasicRepo<int, Saison>
    {
        public SaisonRepo() : base("Saison", "Id_Saison")
        {
        }
        protected override Saison Convert(IDataRecord dtr)
        {
            return new Saison
            {
                Id = (int)dtr["Id_Saison"],
                Id_Serie = (Serie)dtr["Id_Serie"],
                Num_Saison = (int)dtr["Num_Saison"],
                Nom_Saison = dtr["Nom_Saison"].ToString()
            };
        }

        public override bool Delete(Saison id)
        {
            Command cmd = new Command("P_Saison_Delete", true);
            cmd.AddParameter("@Id_Saison", id.Id);
            return ConnectionString?.ExecuteNonQuery(cmd) == 1;
        }

        public override int Insert(Saison entity)
        {
            Command cmd = new Command("P_Saison_Insert", true);
            cmd.AddParameter("@Id_Serie", entity.Id_Serie!);
            cmd.AddParameter("@Num_Saison", entity.Num_Saison!);
            cmd.AddParameter("@Nom_Saison", entity.Nom_Saison!);
            return ConnectionString!.ExecuteNonQuery(cmd);
        }

        public override bool Update(Saison data)
        {
            Command cmd = new Command("P_Saison_Update", true);
            cmd.AddParameter("@Id_Saison", data.Id);
            cmd.AddParameter("@Id_Serie", data.Id_Serie!);
            cmd.AddParameter("@Num_Saison", data.Num_Saison!);
            cmd.AddParameter("@Nom_Saison", data.Nom_Saison!);
            return ConnectionString?.ExecuteNonQuery(cmd) == 1;
        }

    }
}
