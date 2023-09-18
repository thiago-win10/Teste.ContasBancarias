using ContasBancarias.Api.Extensions;
using ContasBancarias.Api.IoC;

namespace ContasBancarias.Api
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }

        public Startup(IConfiguration configuration) => Configuration = configuration;

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddRouting();
            services.AddAuthentication(Configuration);
            services.RegisterServices(Configuration);
        }
    }
}
