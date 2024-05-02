using ExemploApi.Database;
using Microsoft.EntityFrameworkCore;
using Restaurante.Shared.Models;

namespace ExemploApi.Repository
{
    public class UsuarioRepository
    {
        private DatabaseApi _database;
        public UsuarioRepository(DatabaseApi database)
        {
            _database = database;
        }

        public async Task<List<Usuario>> BuscarUsuarios()
        {
            var usuarios = new List<Usuario>() {
                new Usuario { Id = 1, Nome = "Rafael", Email ="Rafael@gmail.com" },
                new Usuario { Id = 2, Nome = "Fernando", Email ="Fernando@gmail.com" }};
            return usuarios;
        }

        public async Task<List<Usuario>> BuscarUsuariosDB()
        {
            var usuarios = await (from usuarioDB in _database.Usuarios
                                  select new Usuario
                                  {
                                      Id = usuarioDB.Id,
                                      Nome = usuarioDB.Nome,
                                      Email = usuarioDB.Email,
                                  }).ToListAsync();
            return usuarios;
        }
    }
}
