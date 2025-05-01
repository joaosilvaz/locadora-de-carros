namespace locadora_de_carros.Data.Repositories.Abstractions
{
    public interface IRepository<T>
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAll();
        T GetId(int id);
    }
}
