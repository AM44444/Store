using System;

namespace DiscountManagement.Application.Contract.CustomerDiscount
{
    public class CustomerDiscountViewModel
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public string Product { get; set; }
        public int DiscountRate { get; set; }
        public string StartDateTime { get; set; }
        public DateTime StartDateTimeGr { get; set; }
        public string EndDateTime { get; set; }
        public DateTime EndDateTimeGr { get; set; }
        public string DiscountReason { get; set; }
        public string CreationDate { get; set; }
    }
}