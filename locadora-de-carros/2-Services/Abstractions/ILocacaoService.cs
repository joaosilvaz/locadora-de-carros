using locadora_de_carros._1_Application.Controllers;
using locadora_de_carros._2_Services.Parameter;
using locadora_de_carros.Application.DTO;

namespace locadora_de_carros._2_Services
{
    // Interface responsável por definir o contrato dos serviços relacionados à locação de veículos.
    public interface ILocacaoService
    {
        RelatorioDTOResponse Calcular(LocacaoDTORequest locacaoBody);
    }
}