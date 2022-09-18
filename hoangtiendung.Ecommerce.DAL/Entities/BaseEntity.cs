namespace hoangtiendung.Ecommerce.DAL.Entities
{
    public class BaseEntity
    {
        Guid ID { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}
