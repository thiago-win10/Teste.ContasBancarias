using DevinBank.Library.Enums;

namespace DevinBank.Library.Modelos
{
    public class TipoTransacao
    {
        public TipoTransacaoEnum IdTransacao { get; }
        public string Nome { get; }
        public TipoTransacao(TipoTransacaoEnum idTransacao)
        {
            IdTransacao = idTransacao;
            Nome = PegaNomeTransacao(idTransacao);
        }

        public static string PegaNomeTransacao(TipoTransacaoEnum idTransacao)
        {
            if (idTransacao == TipoTransacaoEnum.Saque)
            {
                return "Saque";
            }
            else if (idTransacao == TipoTransacaoEnum.Deposito)
            {
                return "Depósito";
            }
            else if (idTransacao == TipoTransacaoEnum.Transferencia)
            {
                return "Transferência";
            }
            else
            {
                return "";
            }

        }

    }
}
