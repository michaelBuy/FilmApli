using FilmApli_DAL;
using FilmApli_Repo.Entities;
using System.Data;


namespace FilmApli_Repo.Repositories
{
    public class PersonneRepo : BasicRepository.BasicRepo<int, Personne>
    {
        public PersonneRepo() : base("Personne", "Id_Personne")
        {
        }
        protected override Personne Convert(IDataRecord dtr)
        {
            return new Personne
            {
                Id = (int)dtr["Id_Personne"],
                Nom = dtr["Nom"].ToString(),
                Prenom = dtr["Prenom"].ToString(),
                DateNaissance = (DateTime)dtr["DateNaissance"],
                Nationalite = dtr["Nationalite"].ToString()
            };
        }

        public override bool Delete(Personne id)
        {
            Command cmd = new Command("P_Personne_Delete", true);
            cmd.AddParameter("@Id_Personne", id.Id);
            return ConnectionString?.ExecuteNonQuery(cmd) == 1;
        }

        public override int Insert(Personne entity)
        {
            Command cmd = new Command("P_Personne_Insert", true);
            cmd.AddParameter("@Nom", entity.Nom!);
            cmd.AddParameter("@Prenom", entity.Prenom!);
            cmd.AddParameter("@DateNaissance", entity.DateNaissance!);
            cmd.AddParameter("@Nationalite", entity.Nationalite!);
            return ConnectionString!.ExecuteNonQuery(cmd);
        }

        public override bool Update(Personne data)
        {
            Command cmd = new Command("P_Personne_Update", true);
            cmd.AddParameter("@Id_Personne", data.Id);
            cmd.AddParameter("@Nom", data.Nom!);
            cmd.AddParameter("@Prenom", data.Prenom!);
            cmd.AddParameter("@DateNaissance", data.DateNaissance!);
            cmd.AddParameter("@Nationalite", data.Nationalite!);
            return ConnectionString!.ExecuteNonQuery(cmd) == 1;
        }
    }
}
