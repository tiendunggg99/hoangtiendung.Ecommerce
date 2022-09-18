using hoangtiendung.Ecommerce.DAL.Data;
using Microsoft.EntityFrameworkCore;

namespace hoangtiendung.Ecommerce.API.ServiceCollection
{
    public static class ServiceRegister
    {
        public static void AddServiceRegisters(this IServiceCollection serviceDescriptors, IConfiguration configuration)
        {
            // Add services to the container.

            serviceDescriptors.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            serviceDescriptors.AddEndpointsApiExplorer();
            serviceDescriptors.AddSwaggerGen();

            serviceDescriptors.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DbConnection")));
            
        }
    }
}
