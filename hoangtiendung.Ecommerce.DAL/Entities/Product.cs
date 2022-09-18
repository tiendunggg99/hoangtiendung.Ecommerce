namespace hoangtiendung.Ecommerce.DAL.Entities
{
    public class Product : BaseEntity
    {
        public virtual IEnumerable<Photo> Galleries { get; set; }
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
