namespace hoangtiendung.Ecommerce.BLL.Models
{
    public class OrderDetailModel : BaseModel
    {
        public Guid ProductId { get; set; }
        public virtual ProductModel Product { get; set; }
        public int Quantity { get; set; }
    }
}
