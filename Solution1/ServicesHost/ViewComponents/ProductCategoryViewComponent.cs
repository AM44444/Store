using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_TennisQuery.Contract.ProductCategoryModel;
using Microsoft.AspNetCore.Mvc;

namespace ServicesHost.ViewComponents
{
    public class ProductCategoryViewComponent :ViewComponent
    {
        private readonly IProductCategoryModel _productCategoryModel;

        public ProductCategoryViewComponent(IProductCategoryModel productCategoryModel)
        {
            _productCategoryModel = productCategoryModel;
        }
        public IViewComponentResult Invoke()
        {
            var productCategory = _productCategoryModel.GetProductCategories();
            return View(productCategory);
        }
    }
}
