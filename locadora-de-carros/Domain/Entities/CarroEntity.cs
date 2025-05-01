using locadora_de_carros.Domain.Entities.Pattern;

namespace locadora_de_carros.Domain.Entities
{
    public class CarroEntity : BaseEntity
    {
        public string? Modelo { get; set; }
        public string? Marca { get; set; }
        public int Ano { get; set; }
        public decimal ValorDiaria { get; set; }
    }
}
