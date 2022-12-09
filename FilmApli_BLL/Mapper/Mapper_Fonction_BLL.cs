using FilmApli_BLL.Models;
using FilmApli_Repo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmApli_BLL.Mapper
{
    public static class Mapper_Fonction_BLL
    {
        public static Fonction_BLL ToRepo(this Fonction fonction)
        {
            return new Fonction_BLL()
            {
                Id = fonction.Id,
                Nom_Fonction = fonction.Nom_Fonction
            };
        }

        public static Fonction ToBll(this Fonction_BLL fonction)
        {
            return new Fonction()
            {
                Id = fonction.Id,
                Nom_Fonction = fonction.Nom_Fonction
            };
        }
    }
}
