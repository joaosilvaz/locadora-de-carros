using locadora_de_carros.Application.DTO;
using locadora_de_carros.Domain.Entities;

namespace locadora_de_carros.Services.Abstractions
{
    // Interface que define as operações disponíveis para manipular Carros.
    public interface ICarroService
    {
        CarroDTO Create(CarroDTO entity);
        CarroDTO Update(int id, CarroDTO entity);
        void Delete(int id);
        List<CarroDTO> GetAll();
        CarroDTO GetById(int id);
    }
}
