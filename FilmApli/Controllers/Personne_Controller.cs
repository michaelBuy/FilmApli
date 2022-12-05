using FilmApli.Mapper;
using FilmApli.Models;
using FilmApli_BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FilmApli.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Personne_Controller : ControllerBase
    {
        private readonly IPersonneService _personneService;

        public Personne_Controller(IPersonneService personneService)
        {
            _personneService = personneService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_personneService.Get(id));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_personneService.GetAll());
        }

        [HttpPost]
        public IActionResult Insert(Personne_C personne)
        {
            return Ok(_personneService.Insert(personne.ToBLL()));
        }

        [HttpPut]
        public IActionResult Update(Personne_C personne)
        {
            return Ok(_personneService.Update(personne.ToBLL()));
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            Personne_C p = new();
            p.Id = id;
            return Ok(_personneService.Delete(p.ToBLL()));
        }
    }
}
