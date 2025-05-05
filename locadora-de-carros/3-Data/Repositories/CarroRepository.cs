using locadora_de_carros.Data.Repositories.Abstractions;
using locadora_de_carros.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace locadora_de_carros.Data.Repositories
{
    // Implementação do repositório de carros, responsável por interagir com o banco de dados.
    public class CarroRepository : ICarrosRepository
    {
        private readonly AppDbContext _context;

        // Construtor com injeção de dependência do contexto do banco de dados.
        public CarroRepository(AppDbContext context)
        {
            _context = context;
        }

        // Cria um novo carro no banco de dados.
        public void Create(CarroEntity entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        // Remove um carro do banco de dados.
        public void Delete(CarroEntity entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        // Retorna a lista de todos os carros cadastrados.
        public List<CarroEntity> GetAll()
        {
            var listCarros = _context.Carros.ToList();

            return listCarros;
        }

        // Busca um carro pelo seu ID.
        public CarroEntity GetId(int id)
        {
             return _context.Carros
                                .AsNoTracking()
                                .FirstOrDefault(p => p.Id == id);
        }

        // Atualiza os dados de um carro existente.
        public void Update(CarroEntity entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
