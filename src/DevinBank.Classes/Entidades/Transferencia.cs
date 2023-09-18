
namespace DevinBank.Library
{
    public class Transferencia
    {
        public IConta ContaOrigem { get; }
        public IConta ContaDestino { get; }
        public decimal Valor { get; }
        public DateTime Data { get; }
        public Transferencia(IConta contaOrigem, IConta contaDestino, decimal valor, DateTime data)
        {
            ContaOrigem = contaOrigem;
            ContaDestino = contaDestino;
            Valor = valor;
            Data = data;
        }

    }
}
