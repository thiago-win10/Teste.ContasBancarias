using DevinBank.Library;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ContasBancarias.Api.Controllers
{
    [Authorize]
    [Route("api/conta")]
    [ApiController]
    public class ContaController : ControllerBase
    {
        private List<Conta> contas = new List<Conta>();
        private Random Random = new Random();

        [HttpPost("Cadastrar")]
        public IActionResult Post([FromBody] Conta conta)
        {
            conta.NumConta = Random.Next(0, conta.NumConta);
            contas.Add(conta);

            return Ok(conta);
        }

        [HttpGet("saldo/{numConta}")]
        public IActionResult ObterSaldo(int numConta)
        {
            var conta = contas.FirstOrDefault(x => x.NumConta == numConta);
            if (conta == null)
            {
                return NotFound("Conta não encontrada");
            }

            return Ok($"Saldo da conta {conta.NumConta}: {conta.Saldo}");
        }

        [HttpGet("extrato/{numConta}")]
        public IActionResult ObterExtrato(int numConta)
        {
            var transaction = contas.Find(x => x.NumConta == numConta);
            if (transaction == null)
            {
                return NotFound("Conta não encontrada");
            }

            return Ok($"Extrato {transaction.Extrato}");
        }

        [HttpPost("transferir")]
        public IActionResult Transferir([FromBody] Transferencia transferencia, int conta)
        {
            var contaOrigem = contas.Find(x => x.NumConta == conta);
            if (contaOrigem == null)
            {
                return NotFound("Conta não existe");
            }

            return Ok(transferencia.Valor);



        }
    }
}
