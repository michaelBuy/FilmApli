using FilmApli_DAL;
using FilmApli_Repo.Entities;
using System.Data;

namespace FilmApli_Repo.Repositories
{
    public class FonctionRepo : BasicRepository.BasicRepo<int, Fonction>
    {
        public FonctionRepo() : base("Fonction", "Id_Fonction")
        {
        }
        protected override Fonction Convert(IDataRecord dtr)
        {
            return new Fonction
            {
                Id = (int)dtr["Id_Fonction"],
                Nom_Fonction = dtr["Nom_Fonction"].ToString(),
            };
        }

        public override bool Delete(Fonction id)
        {
            Command cmd = new Command("P_Fonction_Delete", true);
            cmd.AddParameter("@Id_Fonction", id.Id);
            return ConnectionString?.ExecuteNonQuery(cmd) == 1;
        }

        public override int Insert(Fonction entity)
        {
            Command cmd = new Command("P_Fonction_Insert", true);
            cmd.AddParameter("@Nom_Fonction", entity.Nom_Fonction!);
            return ConnectionString!.ExecuteNonQuery(cmd);
        }

        public override bool Update(Fonction data)
        {
            Command cmd = new Command("P_Fonction_Update", true);
            cmd.AddParameter("@Nom_Fonction", data.Nom_Fonction!);
            cmd.AddParameter("@Id_Fonction", data.Id);
            return ConnectionString?.ExecuteNonQuery(cmd) == 1;
        }

    }
}
