using locadora_de_carros.Application.DTO;
using locadora_de_carros.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace locadora_de_carros.Application.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CarroController : ControllerBase
    {
        private readonly ICarroService carroService;

        public CarroController(ICarroService carroService)
        {
            this.carroService = carroService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CarroDTO>> Get()
        {
            return Ok(carroService.Get());
        }

        [HttpGet("{id:int:min(1)}", Name = "GetUsuarioById")]
        public IActionResult GetId(int id)
        {
            var u1 = carroService.GetId(g => g.Id == id);

            if (u1 is null) return NotFound(u1);

            return Ok(u1);
        }

        [HttpPost]
        public ActionResult<CarroDTO> Post(CarroDTO entidade)
        {
            if (entidade is null) return BadRequest();

            _UsuarioService.Post(entidade);
            return new CreatedAtRouteResult("GetUsuarioById", new { id = entidade.Id }, entidade);
        }

        [HttpPut("{id:int:min(1)}")]
        public ActionResult<CarroDTO> Put(int id, CarroDTO t)
        {
            _UsuarioService.Put(t);
            return Ok(t);
        }

        [HttpDelete("{id:int:min(1)}")]
        public ActionResult<CarroDTO> Delete(int id)
        {
            var u1 = carroService.GetById(id);
            
            if (u1 is null) return NotFound(u1);

            carroService.Delete(u1);

            return Ok();
        }
    }
}
