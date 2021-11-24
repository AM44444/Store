﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopManagement.Application.Contracts.ProductCategory;

namespace ShopManagement.Domain.ProductCategoryAgg
{
   public interface IProductCategoryRepository
   {
       void Create(ProductCategory Entity);
       ProductCategory GetBy(long id);
       List<ProductCategory> GetAll();
       bool Exist(Expression<Func<ProductCategory,bool>>expression);
       void SaveChanges();
       EditProductCategory GetDetails(long id);
       List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel);

   }
}