namespace locadora_de_carros._2_Services.Parameter
{
    // DTO utilizado para receber os dados da solicitação de locação.
    public class LocacaoDTORequest
    {
        public int CarroId { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime  DataFim { get; set; }
    }
}
