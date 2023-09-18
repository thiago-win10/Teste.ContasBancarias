
using DevinBank.Library.Modelos;

namespace DevinBank.Library
{
    public interface IConta
    {
        Agencia Agencia { get; }
        string CPF { get; }
        string Nome { get; }
        int NumConta { get; }
        decimal RendaMensal { get; }
        decimal Saldo { get; }
        public IList<Transacao> Transacoes { get; }
        public IList<Transferencia> Transferencias { get; }

        void Deposito(decimal montante, DateTime data);
        void Saque(decimal montante, DateTime data);
        void Transferencia(Conta contaBeneficiaria, decimal montante, DateTime data);
        string Extrato();
        void AlterarCadastro(string nome);
        void AlterarCadastro(decimal rendaMensal);
        void AlterarCadastro(Agencia agencia);
        void SalvarTransferencia(Conta contaDestino, decimal valor, DateTime data);
        string HistoricoTransferencias();

    }
}