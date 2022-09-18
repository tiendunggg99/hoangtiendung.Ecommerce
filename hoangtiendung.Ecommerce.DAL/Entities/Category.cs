namespace hoangtiendung.Ecommerce.DAL.Entities
{
    public class Category : BaseEntity
    {
        public virtual Photo Logo { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }
    }
}
