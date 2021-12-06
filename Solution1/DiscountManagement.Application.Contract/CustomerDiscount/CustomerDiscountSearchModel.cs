namespace DiscountManagement.Application.Contract.CustomerDiscount
{
    public class CustomerDiscountSearchModel
    {
        public long ProductId { get; set; }
        public string StartDateTime { get; set; }
        public string EndDateTime { get; set; }

    }
}