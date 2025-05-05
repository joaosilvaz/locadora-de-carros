using locadora_de_carros.Application.DTO;
using locadora_de_carros.Services.Abstractions;
using locadora_de_carros.Services.Exceptions;
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

        // Retorna todos os carros cadastrados. 
        // GET /carro
        [HttpGet]
        public ActionResult<IEnumerable<CarroDTO>> GetAll()
        {
            return Ok(carroService.GetAll());
        }

        // Retorna um carro pelo ID.
        // GET /carro/{id}
        [HttpGet("{id:int:min(1)}")]
        public IActionResult GetId(int id)
        {
            try
            {
                var u1 = carroService.GetById(id);

                if (u1 is null) return NotFound(u1);

                return Ok(u1);
            }
            catch (CarrosException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // Cadastra um novo carro.
        // POST /carro
        [HttpPost]
        public ActionResult<CarroDTO> Post([FromBody] CarroDTO entidade)
        {
            if (entidade is null) return BadRequest();

            carroService.Create(entidade);

            return Created();
        }

        // Atualiza um carro existente.
        // PUT /carro/{id}
        [HttpPut("{id:int:min(1)}")]
        public ActionResult<CarroDTO> Put(int id, CarroDTO t)
        {
            try
            {
                carroService.Update(id, t);
                return Ok(t);
            }
            catch (CarrosException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // Remove um carro pelo ID.
        // DELETE /carro/{id}
        [HttpDelete("{id:int:min(1)}")]
        public ActionResult<CarroDTO> Delete(int id)
        {
            carroService.Delete(id);

            return Ok();
        }
    }
}
