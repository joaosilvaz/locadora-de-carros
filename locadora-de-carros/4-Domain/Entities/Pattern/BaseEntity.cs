using System.ComponentModel.DataAnnotations;

namespace locadora_de_carros.Domain.Entities.Pattern
{
    // Serve como base para outras entidades
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
