using Restaurante.Shared.Enums;

namespace Restaurante.Shared.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Salt { get; set; }
        public bool Ativo { get; set; }
        public ETipoUsuario Tipo { get; set; } = ETipoUsuario.Comum;
        public DateTime DataCadastro { get; set; } = DateTime.Now;
    }
}
