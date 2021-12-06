using _0_FrameWork.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountManagement.Domain.CustomerDiscountAgg
{
   public class CustomerDiscount:EntityBase
    {
        public long ProductId { get; private set; }
        public int DiscountRate { get; private set; }
        public DateTime StartDateTime { get; private set; }
        public DateTime EndDateTime { get; private set; }
        public string DiscountReason { get; private set; }

        public CustomerDiscount(long productId, int discountRate, DateTime startDateTime, DateTime endDateTime, string discountReason)
        {
            ProductId = productId;
            DiscountRate = discountRate;
            StartDateTime = startDateTime;
            EndDateTime = endDateTime;
            DiscountReason = discountReason;
        }

        public void Edit(long productId, int discountRate, DateTime startDateTime, DateTime endtDateTime, string discountReason)
        {
            ProductId = productId;
            DiscountRate = discountRate;
            StartDateTime = startDateTime;
            EndDateTime = endtDateTime;
            DiscountReason = discountReason;
        }

    }
}
