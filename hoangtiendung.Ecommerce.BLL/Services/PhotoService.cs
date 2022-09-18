using AutoMapper;
using hoangtiendung.Core.Service.Repository;
using hoangtiendung.Ecommerce.BLL.IServices;
using hoangtiendung.Ecommerce.BLL.Models;
using hoangtiendung.Ecommerce.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace hoangtiendung.Ecommerce.BLL.Services
{
    public class PhotoService : Repository<Photo, PhotoModel>, IPhotoService
    {
        public PhotoService(IMapper mapper, DbContext context) : base(mapper, context)
        {
        }
    }
}
