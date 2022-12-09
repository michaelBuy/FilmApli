using FilmApli.Mapper;
using FilmApli.Models;
using FilmApli_BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FilmApli.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Genre_Controller : ControllerBase
    {
        private readonly IGenreService? _genreService;

        public Genre_Controller(IGenreService? genreService)
        {
            _genreService = genreService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_genreService?.Get(id));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_genreService?.GetAll());
        }

        [HttpPost]
        public IActionResult Insert(Genre_C genre)
        {
            return Ok(_genreService?.Insert(genre.ToBll()));
        }

        [HttpPut]
        public IActionResult Update(Genre_C genre)
        {
            return Ok(_genreService?.Update(genre.ToBll()));
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            Genre_C g = new();
            g.Id = id;
            return Ok(_genreService?.Delete(g.ToBll()));
        }
    }
}
