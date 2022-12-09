using FilmApli_DAL;
using FilmApli_Repo.Interfaces;
using System.Data;
using System.Data.SqlClient;


namespace FilmApli_Repo.Repositories.BasicRepository
{
    public abstract class BasicRepo<Tkey, TEntity> : IRepository<Tkey, TEntity>
        where TEntity : IEntity<Tkey>
    {
        private string connexion = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=DB_FilmApli;Integrated Security=True";

        protected BasicRepo(string entityName, string idName)
        {
            ConnectionString = new Connection(SqlClientFactory.Instance, connexion);
            EntityName = entityName;
            IdName = idName;
        }

        protected Connection? ConnectionString { get; }
        protected string EntityName { get; }
        protected string IdName { get; }


        public TEntity Get(Tkey id)
        {
            Command cmd = new Command("SELECT * FROM [" + EntityName + "]" +
                            "WHERE " + IdName + " = @Id");
            cmd.AddParameter("@Id", id!);
            return ConnectionString.ExecuteReader(cmd, Convert).SingleOrDefault();
        }

        public IEnumerable<TEntity> GetAll()
        {
            Command cmd = new Command("SELECT * FROM [" + EntityName + "]");
            return ConnectionString.ExecuteReader(cmd, Convert);
        }
        protected abstract TEntity Convert(IDataRecord dtr);
        public abstract bool Delete(TEntity id);       
        public abstract Tkey Insert(TEntity entity);
        public abstract bool Update(TEntity data);
        
    }
}
