using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Application;
using _01_TennisQuery.Contract.Product;
using _01_TennisQuery.Contract.ProductCategoryModel;
using DiscountManagement.Infrastructure.EFCore;
using InventoryManagement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Domain.ProductAgg;
using ShopManagement.Infrastructure.EFCore;

namespace _01_TennisQuery.Query
{
    public class ProductCategoryQuery : IProductCategoryModel
    {
        private readonly DiscountContext _discountContext;
        private readonly ShopContext _context;
        private readonly InventoryContext _inventoryContext;
        public ProductCategoryQuery(ShopContext context, InventoryContext inventoryContext, DiscountContext discountContext)
        {
            _context = context;
            _inventoryContext = inventoryContext;
            _discountContext = discountContext;
        }

        public ProductCategoryModel GetProductCategoryWithProductsBy(string slug)
        {
            var discount = _discountContext.
               CustomerDiscounts.Where(x =>
                   x.StartDateTime < DateTime.Now && x.EndDateTime > DateTime.Now)
               .Select(x => new
               {    x.EndDateTime,
                   x.DiscountRate,
                   x.ProductId
               }).ToList();
            var inventory = _inventoryContext.Inventory.Select(x => new { x.ProductId, x.UnitPrice }).ToList();
            var category = _context.ProductCategories
               .Include(x => x.Products)
               .ThenInclude(x => x.Category)
               .Select(x => new ProductCategoryModel
               {
                   Id = x.Id,
                   Name = x.Name,
                   KeyWords = x.KeyWords,
                   MetaDescription = x.MetaDescription,
                   Description = x.Description,
                   Slug = x.Slug,
                   Products = MapProducts(x.Products),

               })
               .FirstOrDefault(x=>x.Slug == slug);
           
            
                foreach (var product in category.Products)
                {
                    var productInventory = inventory
                        .FirstOrDefault(x => x.ProductId == product.Id);
                    if (productInventory != null)
                    {
                        var price = productInventory.UnitPrice;
                        product.UnitPrice = price.ToMoney();
                        var discounts = discount.FirstOrDefault(x => x.ProductId == product.Id);
                        if (discounts != null)
                        {
                            int discountRate = discounts.DiscountRate;
                            product.DiscountRate = discountRate;
                            product.DiscountExpireDate = discounts.EndDateTime.ToDiscountFormat();
                            product.HasDiscountRate = discountRate > 0;
                            var discountAmount = Math.Round((price * discountRate) / 100);
                            product.UnitPriceWithDiscount = (price - discountAmount).ToMoney();
                        }
                    }



                }

           
            return category;
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

        public List<ProductCategoryModel> GetProductCategoriesWithProducts()
        {
            var discount = _discountContext.
                CustomerDiscounts.Where(x =>
                    x.StartDateTime < DateTime.Now && x.EndDateTime > DateTime.Now)
                .Select(x => new
                {
                    x.DiscountRate,
                    x.ProductId
                }).ToList();
            var inventory = _inventoryContext.Inventory.Select(x => new { x.ProductId, x.UnitPrice }).ToList();
            var categories = _context.ProductCategories
               .Include(x => x.Products)
               .ThenInclude(x => x.Category)
               .Select(x => new ProductCategoryModel
               {
                   Id = x.Id,
                   Name = x.Name,
                   Products = MapProducts(x.Products),

               })
               .ToList();
            foreach (var category in categories)
            {
                foreach (var product in category.Products)
                {
                    var productInventory = inventory
                        .FirstOrDefault(x => x.ProductId == product.Id);
                    if (productInventory != null)
                    {
                        var price = productInventory.UnitPrice;
                        product.UnitPrice = price.ToMoney();
                        var discounts = discount.FirstOrDefault(x => x.ProductId == product.Id);
                        if (discounts != null)
                        {
                            int discountRate = discounts.DiscountRate;
                            product.DiscountRate = discountRate;
                            product.HasDiscountRate = discountRate > 0;
                            var discountAmount = Math.Round((price*discountRate) / 100);
                            product.UnitPriceWithDiscount = (price - discountAmount).ToMoney();
                        }
                    }

                    
                   
                }

            }
            return categories;
        }

        private static List<ProductQueryModel> MapProducts(List<Product> products)
        {
            return products.Select(product => new ProductQueryModel
            {
                Id = product.Id,
                Category = product.Category.Name,
                Name = product.Name,
                Picture = product.Picture,
                PictureAlt = product.PictureAlt,
                PictureTitle = product.PictureTitle,
                Slug = product.Slug
            }).ToList();
        }
    }
}
