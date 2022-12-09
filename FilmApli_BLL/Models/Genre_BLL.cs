using FilmApli_Repo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmApli_BLL.Models
{
    public class Genre_BLL : IEntity<int>
    {
        public int Id { get; set; }
        public string? Nom_Genre { get; set; }
    }
}
