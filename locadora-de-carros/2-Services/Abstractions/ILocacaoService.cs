using locadora_de_carros._1_Application.Response;
using locadora_de_carros.Application.DTO;

namespace locadora_de_carros._2_Services
{
    public interface ILocacaoService
    {
        RelatorioResponse Calcular(CarroDTO carroDTO);
    }
}