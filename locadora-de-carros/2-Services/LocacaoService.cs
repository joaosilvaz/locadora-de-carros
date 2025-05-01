using AutoMapper;
using locadora_de_carros._1_Application.Response;
using locadora_de_carros.Application.DTO;

namespace locadora_de_carros._2_Services
{
    public class LocacaoService : ILocacaoService
    {
        private readonly IMapper mapper;

        public RelatorioResponse Calcular(CarroDTO carroDTO)
        {




            return new RelatorioResponse();
        }
    }
}
