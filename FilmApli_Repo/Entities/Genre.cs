using FilmApli_Repo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmApli_Repo.Entities
{
    public class Genre : IEntity<int>
    {
        public int Id { get; set; }
        public string Nom_Genre { get; set; }
    }
}
