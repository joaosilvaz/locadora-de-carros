namespace locadora_de_carros._2_Services.Exceptions
{
    public class LocacaoException : Exception
    {

        private const string MENSAGEM_PADRAO = "Relatório não foi gerado";
        public LocacaoException(string? message) : base(message)
        {
        }
    }
}
