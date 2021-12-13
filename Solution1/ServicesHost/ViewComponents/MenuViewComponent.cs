using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_TennisQuery.Contract.ProductCategoryModel;
using Microsoft.AspNetCore.Mvc;

namespace ServicesHost.ViewComponents
{
    public class MenuViewComponent:ViewComponent
    {
        private IProductCategoryModel _productCategory;

        public MenuViewComponent(IProductCategoryModel productCategory)
        {
            _productCategory = productCategory;
        }

        public IViewComponentResult Invoke()
        {
         
            return View();

        }
    }
}
