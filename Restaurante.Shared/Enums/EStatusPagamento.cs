using System.ComponentModel;

namespace Restaurante.Shared.Enums
{
    public enum EStatusPagamento
    {
        [Description("Pendente")]
        Pendente = 1,

        [Description("Pago")]
        Pago = 2,
    }
}
