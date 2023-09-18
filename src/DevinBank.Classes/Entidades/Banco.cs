
using DevinBank.Library;

namespace ContasBancarias.Domain
{
    public class Banco : IBanco
    {
        public IList<Conta> Contas { get; private set; } = new List<Conta>();
        public DateTime Data { get; private set; } = DateTime.Now;
        public void SalvarConta(Conta conta)
        {
            try
            {
                Contas.Add(conta);
            }
            catch (Exception ex)
            {
                throw new Exception($"Não foi possível salvar conta no sistema. {ex.Message}");
            }
        }
        public Conta AcessarConta(string cpf, int numConta)
        {
            return Contas.FirstOrDefault(conta => conta.CPF == cpf && conta.NumConta == numConta)
                    ?? throw new Exception($"Cliente {cpf} ou conta {numConta} não existem.");
        }
        public Conta AcessarConta(int numConta)
        {
            return Contas.FirstOrDefault(conta => conta.NumConta == numConta)
                    ?? throw new Exception($"Conta {numConta} não existe.");
        }

        public string ListarContas()
        {
            if (Contas.Count < 1)
                throw new Exception("Nenhuma conta cadastrada.");

            var query = Contas.GroupBy(
                conta => conta.GetType(),
                conta => $"\nNúmero da conta: {conta.NumConta}\nCliente: {conta.CPF}\nAgência: {conta.Agencia.Nome}\n",
                (tipo, agrup) => new
                {
                    Key = tipo,
                    G = agrup.ToList()
                });

            string lista = "";

            foreach (var result in query)
            {
                lista += $"\nContas tipo: {result.Key.Name}\n";
                foreach (var conta in result.G)
                {
                    lista += conta;
                }
                lista += "\n#################################################\n";
            }
            return lista;

        }
        public string ListarContasSaldoNegativo()
        {
            if (Contas.Count < 1)
                throw new Exception("Nenhuma conta cadastrada.");

            IEnumerable<Conta> query = Contas.Where(conta => conta.Saldo < 0);
            if (!query.Any())
                throw new Exception("Nenhuma conta com saldo negativo foi encontrada.");

            string lista = "";
            foreach (var conta in query)
            {
                lista += $"{conta.Extrato()}\n¨¨¨ ¨¨¨¨ ¨¨ ¨¨ ¨¨¨¨ ¨¨¨ ¨¨¨ ¨¨¨¨ ¨¨ ¨¨ ¨¨¨¨ ¨¨¨\n";
            }
            return lista;

        }

    }
}