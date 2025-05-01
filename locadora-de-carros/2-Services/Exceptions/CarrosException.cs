namespace locadora_de_carros.Services.Exceptions
{
    public class CarrosException : Exception
    {
        private const string MENSAGEM_PADRAO = "Carro não encontrado"; 
        public CarrosException(string? message = MENSAGEM_PADRAO) : base(message)
        {
        }
    }
}
