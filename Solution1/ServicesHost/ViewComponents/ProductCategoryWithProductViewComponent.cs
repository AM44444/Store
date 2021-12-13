using _01_TennisQuery.Contract.ProductCategoryModel;
using Microsoft.AspNetCore.Mvc;

namespace ServicesHost.ViewComponents
{
    public class ProductCategoryWithProductViewComponent:ViewComponent
    {
        private readonly IProductCategoryModel _productCategoryModel;

        public ProductCategoryWithProductViewComponent(IProductCategoryModel productCategoryModel)
        {
            _productCategoryModel = productCategoryModel;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _productCategoryModel.GetProductCategoriesWithProducts();
            return View(categories);
        }
    }
}
