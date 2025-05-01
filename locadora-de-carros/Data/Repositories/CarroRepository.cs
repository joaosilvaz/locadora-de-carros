using locadora_de_carros.Data.Repositories.Abstractions;
using locadora_de_carros.Domain.Entities;

namespace locadora_de_carros.Data.Repositories
{
    public class CarroRepository : ICarrosRepository
    {
        private readonly AppDbContext _context;

        public CarroRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Create(CarroEntity entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(CarroEntity entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public List<CarroEntity> GetAll()
        {
            var listCarros = _context.Carros.ToList();
            _context.SaveChanges();

            return listCarros;
        }

        public void Update(int id, CarroEntity entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
