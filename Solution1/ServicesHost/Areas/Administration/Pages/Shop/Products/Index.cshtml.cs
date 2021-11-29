using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopManagement.Application.Contracts.Product;
using ShopManagement.Application.Contracts.ProductCategory;

namespace ServicesHost.Areas.Administration.Pages.Shop.Products
{
    public class IndexModel : PageModel
    {
        public SelectList ProductCategories;
        public ProductSearchModel SearchModel;
        public List<ProductViewModel> Product;
        private readonly IProductApplication _productApplication;
        private readonly IProductCategoryApplication _productCategoryApplication;
        public IndexModel(IProductApplication productApplication , IProductCategoryApplication productCategoryApplication)
        {
            _productCategoryApplication = productCategoryApplication;
            _productApplication = productApplication;
        }
        public void OnGet(ProductSearchModel searchModel)
        {
            ProductCategories = new SelectList(_productCategoryApplication.GetProductCategories(), "Id", "Name");
            Product = _productApplication.Search(searchModel);
        }
        public IActionResult OnGetCreate()
        {
            return Partial("./Create", new CreateProduct());
        }
        public JsonResult OnPostCreate(CreateProduct command)
        {
            var result = _productApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var productCategoriesEdit = _productApplication.GetDetails(id);
            return Partial("Edit", productCategoriesEdit);
        }

        public JsonResult OnPostEdit(EditProduct Command)
        {
            var result = _productApplication.Edit(Command);
            return new JsonResult(result);
        }
    }
}
