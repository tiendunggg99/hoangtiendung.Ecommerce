namespace hoangtiendung.Ecommerce.DAL.Entities
{
    public class Promotion : BaseEntity
    {
        public DateTime EffectiveDate { get; set; }
        public DateTime ExpriredDate { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal MinPrice { get; set; }
    }
}
