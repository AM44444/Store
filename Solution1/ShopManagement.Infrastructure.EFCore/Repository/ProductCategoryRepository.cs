﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ShopManagement.Application.Contracts.ProductCategory;
using ShopManagement.Domain.ProductCategoryAgg;

namespace ShopManagement.Infrastructure.EFCore.Repository
{
   public class ProductCategoryRepository : IProductCategoryRepository
   {
       private readonly ShopContext _context;

       public ProductCategoryRepository(ShopContext context)
       {
           _context = context;
       }
       public void Create(ProductCategory Entity)
       {
           _context.ProductCategories.Add(Entity);
       }

        public ProductCategory GetBy(long id)
        {
            return _context.ProductCategories.Find(id);
        }

        public List<ProductCategory> GetAll()
        {
            return _context.ProductCategories.ToList();
        }

        public bool Exist(Expression<Func<ProductCategory, bool>> expression)
        {
          return   _context.ProductCategories.Any(expression);
        }

        public void SaveChanges()
        {

            _context.SaveChanges();
        }

        public EditProductCategory GetDetails(long id)
        {
            return _context.ProductCategories.Select(x => new EditProductCategory
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    KeyWords = x.KeyWords,
                    MetaDescription = x.MetaDescription,
                    Slug = x.Slug,


                }
            ).FirstOrDefault(x=>x.Id==id);
        }

        public List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel)
        {
            var query = _context.ProductCategories.Select(x => new ProductCategoryViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Picture = x.Picture,
                CreationDate = x.CreationDate.ToString(),

            });
            if (!string.IsNullOrWhiteSpace(searchModel.Name))
            {
                query = query.Where(x => x.Name.Contains(searchModel.Name));
            }

            return query.OrderByDescending(x => x.Id).ToList();
        }
    }
}