namespace hoangtiendung.Ecommerce.DAL.Entities
{
    public class BaseEntity
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}
