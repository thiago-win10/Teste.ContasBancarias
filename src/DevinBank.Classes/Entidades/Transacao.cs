
using DevinBank.Library.Modelos;

namespace DevinBank.Library
{
    public class Transacao
    {
        public TipoTransacao TipoTransacao { get; }
        public decimal Valor { get; }
        public DateTime Data { get; }
        public Transacao(TipoTransacao tipo, decimal valor, DateTime date)
        {
            TipoTransacao = tipo;
            Valor = valor;
            Data = date;
        }

    }
}
