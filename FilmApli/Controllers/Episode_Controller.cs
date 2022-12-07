
using FilmApli.Mapper;
using FilmApli.Models;
using FilmApli_BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FilmApli.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Episode_Controller : ControllerBase
    {
        private readonly IEpisodeService _episodeService;

        public Episode_Controller(IEpisodeService episodeService)
        {
            _episodeService = episodeService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_episodeService.Get(id));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_episodeService.GetAll());
        }

        [HttpPost]
        public IActionResult Insert(Episode_C episode)
        {
            return Ok(_episodeService.Insert(episode.ToBLL()));
        }

        [HttpPut]
        public IActionResult Update(Episode_C episode)
        {
            return Ok(_episodeService.Update(episode.ToBLL()));
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            Episode_C e = new();
            e.Id = id;
            return Ok(_episodeService.Delete(e.ToBLL()));
        }
    }
}
