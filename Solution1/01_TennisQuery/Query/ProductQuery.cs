using System;
using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _01_TennisQuery.Contract.Product;
using DiscountManagement.Infrastructure.EFCore;
using InventoryManagement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Infrastructure.EFCore;

namespace _01_TennisQuery.Query
{
    public class ProductQuery : IProductQuery
    {
        private readonly DiscountContext _discountContext;
        private readonly ShopContext _shopContext;
        private readonly InventoryContext _inventoryContext;

        public ProductQuery(DiscountContext discountContext, ShopContext shopContext, InventoryContext inventoryContext)
        {
            _discountContext = discountContext;
            _shopContext = shopContext;
            _inventoryContext = inventoryContext;
        }
        
        public List<ProductQueryModel> GetLatestArrivals()
        {
            var inventory = _inventoryContext.Inventory.Select(x => new { x.ProductId, x.UnitPrice }).ToList();
            var discount = _discountContext.
                CustomerDiscounts.Where(x =>
                    x.StartDateTime < DateTime.Now && x.EndDateTime > DateTime.Now)
                .Select(x => new
                {
                    x.DiscountRate,
                    x.ProductId
                }).ToList();
            var products = _shopContext.Products.Include(x => x.Category)
                   .Select(product => new ProductQueryModel
                   {
                       Id = product.Id,
                       Category = product.Category.Name,
                       Name = product.Name,
                       Picture = product.Picture,
                       PictureAlt = product.PictureAlt,
                       PictureTitle = product.PictureTitle,
                       Slug = product.Slug

                   }).OrderByDescending(x=>x.Id).Take(6).ToList();
            foreach (var product in products)
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
                        var discountAmount = Math.Round((price * discountRate) / 100);
                        product.UnitPriceWithDiscount = (price - discountAmount).ToMoney();
                    }
                }



            }

            return products;
        }
    }
}
