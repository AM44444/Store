using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Application;
using _0_FrameWork.Infrastructure;
using DiscountManagement.Application.Contract.CustomerDiscount;
using DiscountManagement.Domain.CustomerDiscountAgg;
using ShopManagement.Infrastructure.EFCore;

namespace DiscountManagement.Infrastructure.EFCore.Repository
{
   public class CustomerDiscountRepository:RepositoryBase<long,CustomerDiscount>,ICustomerDiscountRepository
   {
       private readonly DiscountContext _context;
       private readonly ShopContext _shopContext;
       public CustomerDiscountRepository(DiscountContext context, ShopContext shopContext) : base(context)
       {
           _context = context;
           _shopContext = shopContext;
       }

       public EditCustomerDiscount GetDetails(long id)
       {
         return  _context.CustomerDiscounts.Select(x => new EditCustomerDiscount
               {
                   ProductId = x.ProductId,
                   DiscountRate = x.DiscountRate,
                   StartDateTime = x.StartDateTime.ToString(),
                   EndDateTime = x.EndDateTime.ToString(),
                   DiscountReason = x.DiscountReason,
                   Id = x.Id
               })
               .FirstOrDefault(x => x.Id == id);
       }

       public List<CustomerDiscountViewModel> Search(CustomerDiscountSearchModel searchModel)
       {
           var products = _shopContext.Products.Select(x => new {x.Id, x.Name}).ToList();
           var query = _context.CustomerDiscounts
               .Select(x => new CustomerDiscountViewModel
               {
                   Id = x.Id,
                   ProductId = x.ProductId,
                   DiscountRate = x.DiscountRate,
                   StartDateTime = x.StartDateTime.ToFarsi(),
                   StartDateTimeGr = x.StartDateTime,
                   EndDateTime = x.EndDateTime.ToFarsi(),
                   EndDateTimeGr = x.EndDateTime,
                   DiscountReason = x.DiscountReason,
                   CreationDate = x.CreationDate.ToFarsi()
               });
           if (searchModel.ProductId >0)
               query = query.Where(x
                   =>
                   x.ProductId == searchModel.ProductId);
           if (!string.IsNullOrWhiteSpace(searchModel.StartDateTime))
           {
              
               query = query.Where(x
                   => 
                   x.StartDateTimeGr > searchModel.StartDateTime.ToGeorgianDateTime());
           }
           if (!string.IsNullOrWhiteSpace(searchModel.EndDateTime))
           {
              
               query = query.Where(x
                   => x.EndDateTimeGr < searchModel.EndDateTime.ToGeorgianDateTime());
           }

           var discounts = query
               .OrderByDescending(x => x.Id)
               .ToList();
           discounts.ForEach(Discount => Discount.Product = products
               .FirstOrDefault(x => x.Id == Discount.ProductId)?.Name);
           return discounts;
       }
   }
}
