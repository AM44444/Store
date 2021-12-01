using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_TennisQuery.Contract.ProductCategoryModel;
using ShopManagement.Infrastructure.EFCore;

namespace _01_TennisQuery.Query
{
   public class ProductCategoryQuery:IProductCategoryModel
   {
       private readonly ShopContext _context;

       public ProductCategoryQuery(ShopContext context)
       {
           _context = context;
       }

       public List<ProductCategoryModel> GetProductCategories()
       {
           return _context.ProductCategories.Select(x => new ProductCategoryModel
           {
               Name = x.Name,
               Picture = x.Picture,
               PictureAlt = x.PictureAlt,
               PictureTitle = x.PictureTitle,
               Slug = x.Slug,
               Id = x.Id

           }).ToList();
       }
    }
}
