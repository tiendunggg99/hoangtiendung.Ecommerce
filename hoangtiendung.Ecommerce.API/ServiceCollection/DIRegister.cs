using hoangtiendung.Ecommerce.BLL.IServices;
using hoangtiendung.Ecommerce.BLL.Services;

namespace hoangtiendung.Ecommerce.API.ServiceCollection
{
    public static class DIRegister
    {
        public static void AddDIRegisters(this IServiceCollection services)
        {
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IOrderDetailService, OrderDetailService>();
            services.AddTransient<IPhotoService, PhotoService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IPromotionService, PromotionService>();
        }
    }
}
