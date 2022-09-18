namespace hoangtiendung.Ecommerce.DAL.Entities
{
    public class Product : BaseEntity
    {
        public virtual IEnumerable<Photo> Galleries { get; set; }
        public decimal Price { get; set; }

    }
}
