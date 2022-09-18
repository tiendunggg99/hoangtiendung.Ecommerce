namespace hoangtiendung.Ecommerce.DAL.Entities
{
    public class OrderDetail : BaseEntity
    {
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int Quantity { get; set; }

    }
}
