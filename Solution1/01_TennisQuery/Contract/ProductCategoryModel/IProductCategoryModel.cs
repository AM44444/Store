using System.Collections.Generic;

namespace _01_TennisQuery.Contract.ProductCategoryModel
{
  public  interface IProductCategoryModel
  {
      ProductCategoryModel GetProductCategoryWithProductsBy(string slug);
      List<ProductCategoryModel> GetProductCategories();
      List<ProductCategoryModel> GetProductCategoriesWithProducts();
  }
}
