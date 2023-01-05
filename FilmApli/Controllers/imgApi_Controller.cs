using FilmApli.Mapper;
using FilmApli.Models;
using FilmApli_BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FilmApli.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class imgApi_Controller : ControllerBase
    {
        private readonly IimgApiService _imgApiService;

        public imgApi_Controller(IimgApiService imgApiService)
        {
            _imgApiService = imgApiService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {            
            return Ok(_imgApiService.Get(id).Id_Film);            
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_imgApiService.GetAll());
        }

        [HttpPost]
        public IActionResult Insert(imgApi_C imgApi)
        {
            return Ok(_imgApiService.Insert(imgApi.ToBll()));
        }

        [HttpPut]
        public IActionResult Update(imgApi_C imgApi)
        {
            return Ok(_imgApiService.Update(imgApi.ToBll()));
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            imgApi_C i = new();
            i.Id = id;
            return Ok(_imgApiService.Delete(i.ToBll()));
        }

    }
}
