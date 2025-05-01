namespace locadora_de_carros._1_Application.Controllers
{
    public class RelatorioDTOResponse
    {
        public string Carro { get; set; }
        public string Marca { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public decimal ValorDiaria { get; set; }
        public decimal SubTotal { get; set; }
        public string Desconto { get; set; }
        public decimal ValorFinal { get; set; }
    }
}
