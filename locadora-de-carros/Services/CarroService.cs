using locadora_de_carros.Data.Repositories.Abstractions;
using locadora_de_carros.Services.Abstractions;

namespace locadora_de_carros.Services
{
    public class CarroService : ICarroService
    {
        private readonly ICarrosRepository carrosRepository;

        public CarroService(ICarrosRepository carrosRepository)
        {
            this.carrosRepository = carrosRepository;
        }


    }
}
