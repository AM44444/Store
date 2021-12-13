using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_TennisQuery.Contract.ProductCategoryModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace ServicesHost.Pages
{
    public class ProductCategoryModel : PageModel
    {
        public _01_TennisQuery.Contract.ProductCategoryModel.ProductCategoryModel ProductCategory;
        private readonly IProductCategoryModel _productCategoryModel;

        public ProductCategoryModel(IProductCategoryModel productCategoryModel)
        {
            _productCategoryModel = productCategoryModel;
        }

        public void OnGet(string id)
        {
            ProductCategory = _productCategoryModel.GetProductCategoryWithProductsBy(id);
        }
    }
}
