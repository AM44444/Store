namespace _01_TennisQuery.Contract.Product
{
   public class ProductQueryModel
    {
        public long Id { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public string Name { get; set; }
        public string UnitPrice { get; set; }
        public string UnitPriceWithDiscount { get; set; }
        public int DiscountRate { get; set; }
        public string Category { get; set; }
        public string Slug { get; set; }
        public bool HasDiscountRate { get; set; }
        public string DiscountExpireDate { get; set; }
    }
}
