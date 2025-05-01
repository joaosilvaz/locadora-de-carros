using AutoMapper;
using locadora_de_carros.Application.DTO;
using locadora_de_carros.Domain.Entities;

namespace locadora_de_carros.Application.Mappers
{
    public class DomainMappingProfile : Profile
    {
        public DomainMappingProfile() 
        {
            CreateMap<CarroEntity, CarroDTO>().ReverseMap();    
        }
    }
}
