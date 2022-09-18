using AutoMapper;
using hoangtiendung.Ecommerce.BLL.Models;
using hoangtiendung.Ecommerce.DAL.Entities;

namespace hoangtiendung.Ecommerce.API.MapperProfile
{
    public class MapperProfileL : Profile
    {
        public MapperProfileL()
        {
            CreateMap<CategoryModel, Category>().ReverseMap();
            CreateMap<Order, OrderModel>().ReverseMap();
            CreateMap<OrderDetail, OrderDetailModel>().ReverseMap();
            CreateMap<Order, OrderModel>().ReverseMap();
            CreateMap<Product, ProductModel>().ReverseMap();
            CreateMap<Promotion, PromotionModel>().ReverseMap();
            CreateMap<Photo, PhotoModel>().ReverseMap();
        }
    }
}
