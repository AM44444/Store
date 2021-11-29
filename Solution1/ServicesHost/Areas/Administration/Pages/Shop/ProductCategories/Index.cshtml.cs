using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopManagement.Application.Contracts.ProductCategory;

namespace ServicesHost.Areas.Administration.Pages.Shop.ProductCategories
{
    public class IndexModel : PageModel
    {
        public ProductCategorySearchModel SearchModel;
        public List<ProductCategoryViewModel> ProductCategory;
        private readonly IProductCategoryApplication _categoryApplication;

        public IndexModel(IProductCategoryApplication categoryApplication)
        {
            _categoryApplication = categoryApplication;
        }
        public void OnGet(ProductCategorySearchModel searchModel)
        {
            ProductCategory = _categoryApplication.Search(searchModel);
        }
        public IActionResult OnGetCreate()
        {
            return Partial("./Create", new CreateProductCategory());
        }
        public JsonResult OnPostCreate(CreateProductCategory command)
        {
            var result = _categoryApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var productCategoriesEdit = _categoryApplication.GetDetails(id);
            return Partial("Edit", productCategoriesEdit);
        }

        public JsonResult OnPostEdit(EditProductCategory Command)
        {
            var productCategoriesEditP = _categoryApplication.Edit(Command);
            return new JsonResult(productCategoriesEditP);
        }
    }
}
