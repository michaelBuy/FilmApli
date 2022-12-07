using FilmApli_Repo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmApli_Repo.Entities
{
    public class Saison : IEntity<int>
    {
        public int Id { get; set; }
        public Serie? Id_Serie { get; set; }
        public int Num_Saison { get; set; }
        public string? Nom_Saison { get; set; }
    }
}
