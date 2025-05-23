﻿using AutoMapper;
using locadora_de_carros._1_Application.Controllers;
using locadora_de_carros._2_Services.Parameter;
using locadora_de_carros.Application.DTO;
using locadora_de_carros.Domain.Entities;
using locadora_de_carros.Services.Abstractions;
using locadora_de_carros.Services.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace locadora_de_carros._2_Services
{
    // Serviço responsável por calcular o valor da locação de um carro.
    public class LocacaoService : ILocacaoService
    {
        private readonly IMapper mapper;
        private readonly ICarroService carroService;
        private int PorcentagemDesconto = 0;
        public LocacaoService(IMapper mapper, ICarroService carroService)
        {
            this.mapper = mapper;
            this.carroService = carroService;
        }

        // Calcula o valor da locação com base na data de início e fim e aplica descontos conforme o período.
        public RelatorioDTOResponse Calcular(LocacaoDTORequest locacaoBody)
        {
            DateTime dataInicio = locacaoBody.DataInicio;
            DateTime dataFim = locacaoBody.DataFim;

            // Busca os dados do carro pelo ID e converte para a entidade
            CarroEntity carro = mapper.Map<CarroEntity>(carroService.GetById(locacaoBody.CarroId));

            if (carro is null)
                throw new CarrosException();

            int dias = (dataFim - dataInicio).Days;
            decimal subtotal = dias * carro.ValorDiaria;
            decimal valorFinal = 0;

            if (dias >= 7)
            {
                PorcentagemDesconto = 10;
                valorFinal = subtotal - ((subtotal / 100) * PorcentagemDesconto);
            }
            else if (dias >= 3)
            {
                PorcentagemDesconto = 5;
                valorFinal = subtotal - ((subtotal / 100) * PorcentagemDesconto);
            }

            // Monta o relatório de resposta com os dados calculados
            var relatorio = new RelatorioDTOResponse()
            {
                Carro = carro.Modelo!,
                Marca = carro.Marca!,
                DataInicio = dataInicio,
                DataFim = dataFim,
                ValorDiaria = carro.ValorDiaria,
                SubTotal = subtotal,
                Desconto = PorcentagemDesconto.ToString() + "%",
                ValorFinal = valorFinal
            };

            return relatorio;
        }
    }
}
