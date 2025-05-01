using locadora_de_carros.Domain.Entities;

namespace locadora_de_carros.Services.Abstractions
{
    public interface ICarroService
    {
        void Create(CarroEntity entity);
        void Update(int id, CarroEntity entity);
        void Delete(CarroEntity entity);
        List<CarroEntity> GetAll();
    }
}
