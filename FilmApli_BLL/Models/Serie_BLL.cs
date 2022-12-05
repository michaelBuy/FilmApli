using FilmApli_Repo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmApli_BLL.Models
{
    public class Serie_BLL : IEntity<int>
    {
        public int Id { get; set; }
        public string? Nom_Serie { get; set; }
        public string? Duree_Serie { get; set; }
        public DateTime DateSortie_Serie { get; set; }
        public string? Synopsis_Serie { get; set; }
        public string? Origine_Serie { get; set; }
    }
}
