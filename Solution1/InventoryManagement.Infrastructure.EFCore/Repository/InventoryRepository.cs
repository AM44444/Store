using System.Collections.Generic;
using System.Linq;
using _0_FrameWork.Infrastructure;
using InventoryManagement.Application.Contract.Inventory;
using InventoryManagement.Domain.InventoryAgg;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Infrastructure.EFCore;

namespace InventoryManagement.Infrastructure.EFCore.Repository
{
    public class InventoryRepository:RepositoryBase<long,Inventory>,IInventoryRepository
    {
        private readonly ShopContext _shopContext;
        private readonly InventoryContext _context;
        public InventoryRepository( InventoryContext context1, ShopContext shopContext) : base(context1)
        {
            _context = context1;
            _shopContext = shopContext;
        }

        public EditInventory GetDetails(long id)
        {
            return _context.Inventory.Select(x => new EditInventory
                {
                    Id = x.Id,
                    ProductId = x.ProductId,
                    UnitPrice = x.UnitPrice
                })
                .FirstOrDefault(x => x.Id == id);
        }

        public Inventory GetBy(long productId)
        {
            return _context.Inventory.FirstOrDefault(x => x.ProductId == productId);
        }

        public List<InventoryViewModel> Search(InventorySearchModel searchModel)
        {
            var products = _shopContext.Products.Select(x => new {x.Id, x.Name});
            var query = _context.Inventory.Select(x => new InventoryViewModel
            {
                Id = x.Id,
                UnitPrice = x.UnitPrice,
                InStock = x.InStock,
                ProductId = x.ProductId
                ,CurrentCount = x.CalculateCurrentCount(),
            });
            if (searchModel.ProductId > 0)
                query = query.Where(x => x.ProductId == searchModel.ProductId);
            if (!searchModel.InStock)
                query = query.Where(x => !x.InStock);
            var inventory = query.OrderByDescending(x => x.Id).ToList();
            inventory.ForEach(item =>
            
                item.Product = products.FirstOrDefault(x => x.Id == item.ProductId)?.Name);
         
            return inventory;
        }
    }
}
