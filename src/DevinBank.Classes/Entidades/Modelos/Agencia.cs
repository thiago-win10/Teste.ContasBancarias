
using DevinBank.Library.Enums;

namespace DevinBank.Library.Modelos
{
    public class Agencia
    {
        public AgenciaEnum IdAgencia { get; }
        public string Nome { get; }
        public Agencia(AgenciaEnum agencia)
        {
            IdAgencia = agencia;
            Nome = PegaNome(agencia);
        }

        public static string PegaNome(AgenciaEnum agencia)
        {
            if (agencia == AgenciaEnum.Lapa)
            {
                return "001 - Lapa";
            }
            else if (agencia == AgenciaEnum.Morumbi)
            {
                return "002 - Morumbi";
            }
            else
            {
                return "003 - Jardins";
            }
        }

    }
}
