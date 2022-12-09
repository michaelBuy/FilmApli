using FilmApli.Mapper;
using FilmApli.Models;
using FilmApli_BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FilmApli.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Fonction_Controller : ControllerBase
    {
        private readonly IFonctionService? _fonctionService;

        public Fonction_Controller(IFonctionService? fonctionService)
        {
            _fonctionService = fonctionService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_fonctionService?.Get(id));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_fonctionService?.GetAll());
        }

        [HttpPost]
        public IActionResult Insert(Fonction_C fonction)
        {
            return Ok(_fonctionService?.Insert(fonction.ToBll()));
        }

        [HttpPut]
        public IActionResult Update(Fonction_C fonction)
        {
            return Ok(_fonctionService?.Update(fonction.ToBll()));
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            Fonction_C f = new();
            f.Id = id;
            return Ok(_fonctionService?.Delete(f.ToBll()));
        }
    }
}
