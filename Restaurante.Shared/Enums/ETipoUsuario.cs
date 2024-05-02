using System.ComponentModel;

namespace Restaurante.Shared.Enums
{
    public enum ETipoUsuario
    {
        [Description("Dev")]
        Dev = 1,

        [Description("Admin")]
        Admin = 2,

        [Description("Comum")]
        Comum = 3,

        [Description("Garçom")]
        Garcom = 3
    }
}
