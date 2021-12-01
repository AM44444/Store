using System.Collections.Generic;

namespace _01_TennisQuery.Contract.ProductCategoryModel
{
  public  interface IProductCategoryModel
  {
      List<ProductCategoryModel> GetProductCategories();
  }
}
