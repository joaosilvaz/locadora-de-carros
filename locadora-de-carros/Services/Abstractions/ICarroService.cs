using locadora_de_carros.Application.DTO;
using locadora_de_carros.Domain.Entities;

namespace locadora_de_carros.Services.Abstractions
{
    public interface ICarroService
    {
        void Create(CarroDTO entity);
        void Update(int id, CarroDTO entity);
        void Delete(int id);
        List<CarroDTO> GetAll();

        CarroDTO GetById(int id);
    }
}
