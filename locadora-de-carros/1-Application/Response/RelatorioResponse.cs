using locadora_de_carros.Application.DTO;
using locadora_de_carros.Domain.Entities;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace locadora_de_carros._1_Application.Response
{
    public class RelatorioResponse
    {
        public CarroDTO Carro { get; set; }
        public DateTime PeriodoLocacao { get; set; }
        public decimal ValorDiaria { get; set; }
        public decimal SubTotal { get; set; }
        public decimal DescontoAplicado { get; set; }
        public  decimal ValorFinal { get; set; }
    }
}
