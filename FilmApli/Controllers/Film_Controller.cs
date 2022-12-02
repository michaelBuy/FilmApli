using FilmApli_BLL.Interfaces;
using FilmApli.Mapper;
using Microsoft.AspNetCore.Mvc;
using FilmApli.Models;

namespace FilmApli.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Film_Controller : ControllerBase
    {
        private readonly IFilmService _filmService;

        public Film_Controller(IFilmService filmService)
        {
            _filmService = filmService;
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_filmService?.Get(id));
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_filmService?.GetAll());
        }
        [HttpPost]
        public IActionResult Insert(Film_C film)
        {
            return Ok(_filmService?.Insert(film.ToBLL()));
        }
        [HttpPut]
        public IActionResult Update(Film_C film)
        {
            return Ok(_filmService?.Update(film.ToBLL()));
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            Film_C f = new();
            f.Id = id;
            return Ok(_filmService.Delete(f.ToBLL()));
        }
    }
}
