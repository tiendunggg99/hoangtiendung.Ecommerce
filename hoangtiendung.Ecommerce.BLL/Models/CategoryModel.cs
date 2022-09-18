namespace hoangtiendung.Ecommerce.BLL.Models
{
    public class CategoryModel : BaseModel
    {
        public virtual PhotoModel Logo { get; set; }
        public virtual IEnumerable<ProductModel> Products { get; set; }
    }
}
