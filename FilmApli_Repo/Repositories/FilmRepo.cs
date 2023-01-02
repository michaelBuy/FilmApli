using FilmApli_DAL;
using FilmApli_Repo.Entities;
using System.Data;


namespace FilmApli_Repo.Repositories
{
    public class FilmRepo : BasicRepository.BasicRepo<int, Film>
    {
        public FilmRepo() : base("Film", "Id_Film")
        {
        }

        protected override Film Convert(IDataRecord dtr)
        {
            return new Film
            {
                Id = (int)dtr["Id_Film"],
                Titre = dtr["Titre"].ToString(),
                DateSortie = dtr["DateSortie"] == DBNull.Value ? null : (DateTime)dtr["DateSortie"],
                Duree = dtr["Duree"].ToString(),
                Origine = dtr["Origine"].ToString(),
                Synopsis_Film = dtr["Synopsis_Film"].ToString(),
                //Img_Url = dtr["Img_Url"].ToString()
            };          
        }

        public override bool Delete(Film id)
        {
            Command cmd = new Command("P_Film_Delete", true);
            cmd.AddParameter("@Id_Film", id.Id);
            return ConnectionString?.ExecuteNonQuery(cmd) == 1;
        }

        public override int Insert(Film entity)
        {
            Command cmd = new Command("P_Film_Insert", true);
            cmd.AddParameter("@Titre", entity.Titre!);
            cmd.AddParameter("@DateSortie", entity.DateSortie!);
            cmd.AddParameter("@Duree", entity.Duree!);
            cmd.AddParameter("@Origine", entity.Origine!);
            cmd.AddParameter("@Synopsis", entity.Synopsis_Film!);
            //cmd.AddParameter("@Img_Url", entity.Img_Url);
            return ConnectionString!.ExecuteNonQuery(cmd);
        }

        public override bool Update(Film data)
        {
            Command cmd = new Command("P_Film_Update", true);
            cmd.AddParameter("@Id_Film", data.Id);
            cmd.AddParameter("@Titre", data.Titre!);
            cmd.AddParameter("@DateSortie", data.DateSortie!);
            cmd.AddParameter("@Duree", data.Duree!);
            cmd.AddParameter("@Origine", data.Origine!);
            cmd.AddParameter("@Synopsis", data.Synopsis_Film!);
            /*cmd.AddParameter("@Img_Url", data.Img_Url);*/
            return ConnectionString!.ExecuteNonQuery(cmd) == 1;
        }
    }
}
