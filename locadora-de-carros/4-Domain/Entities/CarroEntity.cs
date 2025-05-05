using System.ComponentModel.DataAnnotations.Schema;
using locadora_de_carros.Domain.Entities.Pattern;
using Microsoft.EntityFrameworkCore;

namespace locadora_de_carros.Domain.Entities
{
    // Entidade que representa a tabela de carros no banco de dados.
    [Table("TB_CARRO")]
    public class CarroEntity : BaseEntity
    {

        [Column("ds_modelo")]
        public string? Modelo { get; set; }

        [Column("ds_marca")]
        public string? Marca { get; set; }

        [Column("nr_ano")]
        public int Ano { get; set; }

        [Column("nr_valordiaria")]
        [Precision(10, 2)]
        public decimal ValorDiaria { get; set; }
    }
}
