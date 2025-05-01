using locadora_de_carros._1_Application.Response;
using locadora_de_carros._2_Services;
using locadora_de_carros._2_Services.Exceptions;
using locadora_de_carros.Application.DTO;
using Microsoft.AspNetCore.Mvc;

namespace locadora_de_carros.Application.Controllers
{

    [ApiController]
    [Route("/api/locacoes")]
    public class LocacaoController : ControllerBase
    {
        private readonly ILocacaoService locacaoService;

        public LocacaoController(ILocacaoService locacaoService)
        {
            this.locacaoService = locacaoService;
        }


        [HttpPost("/calcular")]
        public ActionResult<RelatorioResponse> Create([FromBody] int id,DateTime dataInicio, DateTime dataFim)
        {
            try
            {
              RelatorioResponse relatorioResponse =  locacaoService.Calcular(new CarroDTO());
              return relatorioResponse;
            }
            catch (LocacaoException ex)
            {
                return BadRequest(ex.Message);  
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }
    }
}
