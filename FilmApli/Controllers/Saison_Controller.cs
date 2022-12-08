using FilmApli.Mapper;
using FilmApli.Models;
using FilmApli_BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FilmApli.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Saison_Controller : ControllerBase
    {
        private readonly ISaisonService? _saison;

        public Saison_Controller(ISaisonService? saison)
        {
            _saison = saison;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_saison?.Get(id));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_saison?.GetAll());
        }

        [HttpPost]
        public IActionResult Insert(Saison_C saison)
        {
            return Ok(_saison?.Insert(saison.ToBll()));
        }

        [HttpPut]
        public IActionResult Update(Saison_C saison)
        {
            return Ok(_saison?.Update(saison.ToBll()));
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            Saison_C s = new();
            s.Id = id;
            return Ok(_saison?.Delete(s.ToBll()));
        }
    }
}
