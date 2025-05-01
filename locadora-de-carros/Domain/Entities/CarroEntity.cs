using System.ComponentModel.DataAnnotations.Schema;
using locadora_de_carros.Domain.Entities.Pattern;

namespace locadora_de_carros.Domain.Entities
{


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
        public decimal ValorDiaria { get; set; }
    }
}
