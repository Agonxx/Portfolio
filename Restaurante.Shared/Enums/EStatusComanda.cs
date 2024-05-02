using System.ComponentModel;

namespace Restaurante.Shared.Enums
{
    public enum EStatusComanda
    {
        [Description("Aberta")]
        Aberta = 1,

        [Description("Encerrada")]
        Encerrada = 2,

        [Description("Cancelada")]
        Cancelada = 3,
    }
}
