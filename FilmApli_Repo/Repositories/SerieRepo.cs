using FilmApli_DAL;
using FilmApli_Repo.Entities;
using System.Data;

namespace FilmApli_Repo.Repositories
{
    public class SerieRepo : BasicRepository.BasicRepo<int, Serie>
    {
        public SerieRepo() : base("Serie", "Id_Serie")
        {
        }
        protected override Serie Convert(IDataRecord dtr)
        {
            return new Serie
            {
                Id = (int)dtr["Id_Serie"],
                Nom_Serie = dtr["Nom_Serie"].ToString(),
                Duree_Serie = dtr["Duree_Serie"].ToString(),
                DateSortie_Serie = (DateTime)dtr["DateSortie_Serie"],
                Synopsis_Serie = dtr["Synopsis_Serie"].ToString(),
                Origine_Serie = dtr["Origine_Serie"].ToString()
            };
        }

        public override bool Delete(Serie id)
        {
            Command cmd = new Command("P_Serie_Delete", true);
            cmd.AddParameter("@Id_Serie", id.Id);
            return ConnectionString?.ExecuteNonQuery(cmd) == 1;
        }

        public override int Insert(Serie entity)
        {
            Command cmd = new Command("P_Serie_Insert", true);
            cmd.AddParameter("@Nom_Serie", entity.Nom_Serie!);
            cmd.AddParameter("@Duree_Serie", entity.Duree_Serie!);
            cmd.AddParameter("@DateSortie_Serie", entity.DateSortie_Serie!);
            cmd.AddParameter("@Synopsis_Serie", entity.Synopsis_Serie!);
            cmd.AddParameter("@Origine_Serie", entity.Origine_Serie!);
            return ConnectionString!.ExecuteNonQuery(cmd);
        }

        public override bool Update(Serie data)
        {
            Command cmd = new Command("P_Serie_Update", true);
            cmd.AddParameter("@Id_Serie", data.Id);
            cmd.AddParameter("@Nom_Serie", data.Nom_Serie!);
            cmd.AddParameter("@Duree_Serie", data.Duree_Serie!);
            cmd.AddParameter("@DateSortie_Serie", data.DateSortie_Serie!);
            cmd.AddParameter("@Synopsis_Serie", data.Synopsis_Serie!);
            cmd.AddParameter("@Origine_Serie", data.Origine_Serie!);
            return ConnectionString!.ExecuteNonQuery(cmd) == 1;
        }

    }
}
