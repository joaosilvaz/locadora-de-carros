using AutoMapper;
using locadora_de_carros.Application.DTO;
using locadora_de_carros.Domain.Entities;

namespace locadora_de_carros.Application.Mappers
{
    public class DomainModelMappingProfile : Profile
    {
        public DomainModelMappingProfile() 
        {
            CreateMap<CarroEntity, CarroDTO>().ReverseMap();    
        }
    }
}
