namespace locadora_de_carros.Services.Exceptions
{
    // Exceção personalizada para tratar erros relacionados a operações com carros.
    public class CarrosException : Exception
    {
        private const string MENSAGEM_PADRAO = "Carro não encontrado"; 
        public CarrosException(string? message = MENSAGEM_PADRAO) : base(message)
        {
        }
    }
}
