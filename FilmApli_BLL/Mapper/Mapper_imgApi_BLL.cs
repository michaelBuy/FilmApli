using FilmApli_BLL.Models;
using FilmApli_Repo.Entities;


namespace FilmApli_BLL.Mapper
{
    public static class Mapper_imgApi_BLL 
    {
        public static imgApi_BLL ToBll(this imgApi imgApi)
        {           
            return new imgApi_BLL
            {
                Id = imgApi.Id,
                Id_Beta = imgApi.Id_Beta,
                Id_Film = imgApi.Id_Film
            };
        }

        public static imgApi ToRepo(this imgApi_BLL imgApi)
        {
            return new imgApi
            {
                Id = imgApi.Id,
                Id_Film = imgApi.Id_Film,
                Id_Beta = imgApi.Id_Beta
            };
        }
    }
}
