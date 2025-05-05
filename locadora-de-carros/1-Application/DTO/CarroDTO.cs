using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace locadora_de_carros.Application.DTO
{
    // DTO (Data Transfer Object) utilizado para representar os dados de um carro.
    public class CarroDTO
    {
        [Required(ErrorMessage = "O modelo é obrigatório.")]
        [MinLength(1, ErrorMessage = "O modelo não pode ser vazio.")]
        public string? Modelo { get; set; }

        [Required(ErrorMessage = "A marca é obrigatória.")]
        [MinLength(1, ErrorMessage = "A marca não pode ser vazia.")]
        public string? Marca { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O ano não pode ser menor que 0.")]
        public int Ano { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "O valor da diária não pode ser menor que 0.")]
        public decimal ValorDiaria { get; set; }
    }
}
