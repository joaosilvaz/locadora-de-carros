using AutoMapper;
using locadora_de_carros.Application.DTO;
using locadora_de_carros.Data.Repositories.Abstractions;
using locadora_de_carros.Domain.Entities;
using locadora_de_carros.Services.Abstractions;
using locadora_de_carros.Services.Exceptions;

namespace locadora_de_carros.Services
{
    public class CarroService : ICarroService
    {
        private readonly ICarrosRepository carrosRepository;
        private readonly IMapper mapper;

        public CarroService(ICarrosRepository carrosRepository, IMapper mapper)
        {
            this.carrosRepository = carrosRepository;
            this.mapper = mapper;
        }

        public void Create(CarroDTO entity)
        {


            var usuario = mapper.Map<CarroEntity>(entity);

            carrosRepository.Create(usuario);
        }

        public void Update(int id, CarroDTO entity)
        {
            var carro = mapper.Map<CarroEntity>(entity);
            var carroExistente = carrosRepository.GetId(id);

            if (carroExistente is null) 
                    throw new CarrosException();

            carro.Id = id;

            carrosRepository.Update(carroExistente);

        }

        public void Delete(int id)
        {
            var carroExistente = carrosRepository.GetId(id);

            if (carroExistente is null)
                throw new CarrosException();

            carrosRepository.Delete(carroExistente);
        }

        public List<CarroDTO> GetAll() => mapper.Map<List<CarroDTO>>(carrosRepository.GetAll());
        public CarroDTO GetById(int id) => mapper.Map<CarroDTO>(carrosRepository.GetId(id));
    }
}
