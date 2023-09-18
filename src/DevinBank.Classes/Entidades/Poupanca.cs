using DevinBank.Library.Modelos;

namespace DevinBank.Library
{
    public class Poupanca : Conta
    {
        public Poupanca(string nome, string cpf, decimal rendaMensal, Agencia agencia)
            : base(nome, cpf, rendaMensal, agencia)
        {
        }

        public static decimal SimularRendimento(decimal saldo, int meses, int rentabilidade)
        {

            decimal txMensal = ((decimal)Math.Pow(1 + ((double)rentabilidade / 100), 1.0 / 12) - 1) * 100m;

            return saldo * (txMensal * meses / 100);

        }

    }
}
