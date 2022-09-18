namespace hoangtiendung.Ecommerce.DAL.Entities
{
    public class Order : BaseEntity
    {
        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }
        public Guid PromotionId { get; set; }
        public virtual Promotion Promotion { get; set; }
    }
}
