using FilmApli.Mapper;
using FilmApli.Models;
using FilmApli_BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FilmApli.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Serie_Controller : ControllerBase
    {
        private readonly ISerieService _serieService;

        public Serie_Controller(ISerieService serieService)
        {
            _serieService = serieService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_serieService.Get(id));
        }

        [HttpGet]
        public IActionResult getAll()
        {
            return Ok(_serieService.GetAll());
        }

        [HttpPost]
        public IActionResult Insert(Serie_C serie)
        {
            return Ok(_serieService.Insert(serie.ToBLL()));
        }

        [HttpPut]
        public IActionResult Update(Serie_C serie)
        {
            return Ok(_serieService.Update(serie.ToBLL()));
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            Serie_C s = new Serie_C();
            s.Id = id;
            return Ok(_serieService.Delete(s.ToBLL()));
        }
    }
}
