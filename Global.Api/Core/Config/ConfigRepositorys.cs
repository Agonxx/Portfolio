using ExemploApi.Repository;

namespace ExemploApi.Core.Config
{
    public static class ConfigRepositorys
    {
        public static void ConfigurarRepositorys(IServiceCollection services)
        {
            services.AddScoped<UsuarioRepository>();
        }
    }
}
