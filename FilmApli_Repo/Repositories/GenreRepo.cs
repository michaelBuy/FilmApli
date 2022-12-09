using FilmApli_DAL;
using FilmApli_Repo.Entities;
using System.Data;


namespace FilmApli_Repo.Repositories
{
    public class GenreRepo : BasicRepository.BasicRepo<int, Genre>
    {
        public GenreRepo() : base("Genre", "Id_Genre")
        {
        }

        protected override Genre Convert(IDataRecord dtr)
        {
            return new Genre
            {
                Id = (int)dtr["Id_Genre"],
                Nom_Genre = dtr["Nom_Genre"].ToString()!
            };
        }

        public override bool Delete(Genre id)
        {
            Command cmd = new Command("P_Genre_Delete", true);
            cmd.AddParameter("@Id_Genre", id.Id);
            return ConnectionString?.ExecuteNonQuery(cmd) == 1;
        }

        public override int Insert(Genre entity)
        {
            Command cmd = new Command("P_Genre_Insert", true);
            cmd.AddParameter("@Nom_Genre", entity.Nom_Genre);
            return ConnectionString!.ExecuteNonQuery(cmd);
        }

        public override bool Update(Genre data)
        {
            Command cmd = new Command("P_Genre_Update", true);
            cmd.AddParameter("@Nom_Genre", data.Nom_Genre);
            cmd.AddParameter("@Id_Genre", data.Id);
            return ConnectionString?.ExecuteNonQuery(cmd) == 1;
        }
    }
}
