using FilmApli.Models;
using FilmApli_BLL.Models;

namespace FilmApli.Mapper
{
    public static class Mapper_imgApi_Client
    {
        public static imgApi_C ToClient(this imgApi_BLL imgApi)
        {
            return new imgApi_C()
            {
                Id = imgApi.Id,
                Id_Film = imgApi.Id_Film,
                Id_Beta = imgApi.Id_Beta
            };
        }

        public static imgApi_BLL ToBll(this imgApi_C imgApi)
        {
            return new imgApi_BLL
            {
                Id = imgApi.Id,
                Id_Film = imgApi.Id_Film,
                Id_Beta = imgApi.Id_Beta
            };
        }
    }
}
