using locadora_de_carros._1_Application.Controllers;
using locadora_de_carros._2_Services;
using locadora_de_carros._2_Services.Parameter;
using locadora_de_carros.Application.DTO;
using locadora_de_carros.Services.Exceptions;
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

        // Calcula o valor de uma locação com base nas regras do sistema.
        // Rota: POST /calcular
        [HttpPost("/calcular")]
        public ActionResult<RelatorioDTOResponse> Create([FromBody] LocacaoDTORequest locacaoBody)
        {
            try
            {
                // Chama o serviço para calcular o relatório da locação
                RelatorioDTOResponse relatorioResponse = locacaoService.Calcular(locacaoBody);
                return relatorioResponse;
            }catch(CarrosException ex)
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
