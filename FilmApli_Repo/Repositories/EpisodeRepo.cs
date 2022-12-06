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
    public class EpisodeRepo : BasicRepository.BasicRepo<int, Episode>
    {
        public EpisodeRepo() : base("Episode", "Id_Episode")
        {
        }

        protected override Episode Convert(IDataRecord dtr)
        {
            return new Episode
            {
                Id = (int)dtr["Id_Episode"],
                Numero_Episode = (int)dtr["Numero_Episode"],
                Date_Diffusion = (DateTime)dtr["Date_Diffusion"],
                Titre_Episode = dtr["Titre_Episode"].ToString(),
                Synopsis_Episode = dtr["Synopsis_Episode"].ToString(),
                Id_Saison = (Saison)dtr["Id_Saison"]
            };
        }
        public override bool Delete(Episode id)
        {
            Command cmd = new Command("P_Episode_Delete", true);
            cmd.AddParameter("@Id_Episode", id.Id);
            return ConnectionString?.ExecuteNonQuery(cmd) == 1;
        }

        public override int Insert(Episode entity)
        {
            Command cmd = new Command("P_Episode_Insert", true);
            cmd.AddParameter("@Numero_Episode", entity.Numero_Episode);
            cmd.AddParameter("@Date_Diffusion", entity.Date_Diffusion);
            cmd.AddParameter("@Titre_Episode", entity.Titre_Episode!);
            cmd.AddParameter("@Synopsis_Episode", entity.Synopsis_Episode!);
            cmd.AddParameter("@Id_Saison", entity.Id_Saison!);
            return ConnectionString!.ExecuteNonQuery(cmd);
        }

        public override bool Update(Episode data)
        {
            Command cmd = new Command("P_Episode_Update", true);
            cmd.AddParameter("@Numero_Episode", data.Numero_Episode);
            cmd.AddParameter("@Date_Diffusion", data.Date_Diffusion);
            cmd.AddParameter("@Titre_Episode", data.Titre_Episode!);
            cmd.AddParameter("@Synopsis_Episode", data.Synopsis_Episode!);
            cmd.AddParameter("@Id_Saison", data.Id_Saison!);
            cmd.AddParameter("@Id_Episode", data.Id!);
            return ConnectionString?.ExecuteNonQuery(cmd) == 1;
        }
    }
}
