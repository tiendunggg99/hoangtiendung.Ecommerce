namespace hoangtiendung.Ecommerce.BLL.Models
{
    public class ProductModel : BaseModel
    {
        public virtual IEnumerable<PhotoModel> Galleries { get; set; }
        public decimal Price { get; set; }
        public Rate Rate { get; set; }
    }
    public enum Rate
    {
        Excellence,
        Good,
        Normal,
        Bad
    }
}
