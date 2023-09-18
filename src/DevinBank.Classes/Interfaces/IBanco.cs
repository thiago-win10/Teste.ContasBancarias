
using DevinBank.Library;

namespace ContasBancarias.Domain
{
    public interface IBanco
    {
        IList<Conta> Contas { get; }
        DateTime Data { get; }
        void SalvarConta(Conta conta);
        Conta AcessarConta(string cpf, int numConta);
        Conta AcessarConta(int numConta);
        string ListarContas();
    }
}