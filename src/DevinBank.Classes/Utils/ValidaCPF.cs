namespace DevinBank.Library.Utils
{
    // <summary >
    // método de validação de CPF extraído de https://www.macoratti.net/11/09/c_val1.htm
    // regra de negócio https://www.macoratti.net/alg_cpf.htm
    // <summary />
    public static class ValidaCPF
    {
        public static bool IsCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;

            //tratamento da string: remove possíveis espaços em branco, pontos e hífens
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            //checa se o valor informado tem o tamanho esperado e guarda os primeiros 9 caracteres
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            //multiplica os primeiros 9 caracteres cada um com seu respectivo multiplicador e acumula o resultado
            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            //verifica o resto da soma/11 e conforme a regra de negocio chega ao valor do primeiro digito verificador
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();

            //repete o processo anterior, agora incluindo o primeiro digito verificador encontrado
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            //encontrado o segundo digito, o concatena com o primeiro e faz comparação com o valor de cpf recebido, retornando verdadeiro ou falso
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }
    }
}