namespace hoangtiendung.Ecommerce.BLL.Models
{
    public class OrderModel : BaseModel
    {
        public virtual IEnumerable<OrderDetailModel> OrderDetails { get; set; }
        public Guid PromotionId { get; set; }
        public virtual PromotionModel Promotion { get; set; }
    }
}
