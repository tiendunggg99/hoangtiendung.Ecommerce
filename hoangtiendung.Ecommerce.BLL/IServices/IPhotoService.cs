using hoangtiendung.Core.Service.IRepository;
using hoangtiendung.Ecommerce.BLL.Models;
using hoangtiendung.Ecommerce.DAL.Entities;

namespace hoangtiendung.Ecommerce.BLL.IServices
{
    public interface IPhotoService : IRepository<Photo, PhotoModel>
    {
    }
}
