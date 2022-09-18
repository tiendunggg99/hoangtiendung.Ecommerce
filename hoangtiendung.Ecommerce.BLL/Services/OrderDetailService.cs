using AutoMapper;
using hoangtiendung.Core.Service.Repository;
using hoangtiendung.Ecommerce.BLL.IServices;
using hoangtiendung.Ecommerce.BLL.Models;
using hoangtiendung.Ecommerce.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace hoangtiendung.Ecommerce.BLL.Services
{
    public class OrderDetailService : Repository<OrderDetail, OrderDetailModel>, IOrderDetailService
    {
        public OrderDetailService(IMapper mapper, DbContext context) : base(mapper, context)
        {
        }
    }
}
