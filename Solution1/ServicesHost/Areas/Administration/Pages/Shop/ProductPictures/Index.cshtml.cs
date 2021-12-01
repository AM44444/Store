using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopManagement.Application.Contracts.Product;
using ShopManagement.Application.Contracts.ProductCategory;
using ShopManagement.Application.Contracts.ProductPicture;

namespace ServicesHost.Areas.Administration.Pages.Shop.ProductPictures
{
    public class IndexModel : PageModel
    {   [TempData]
        public string Message { get; set; }
        public SelectList Product;
        public ProductPictureSearchModel SearchModel;
        public List<ProductPictureViewModel> ProductPicture;
        private readonly IProductApplication _productApplication;
        private readonly IProductPictureApplication _productPictureApplication;
        public IndexModel(IProductApplication productApplication , IProductPictureApplication productPictureApplication)
        {
            _productPictureApplication = productPictureApplication;
            _productApplication = productApplication;
        }
        public void OnGet(ProductPictureSearchModel searchModel)
        {
            Product = new SelectList(_productApplication.GetProducts(), "Id", "Name");
            ProductPicture = _productPictureApplication.Search(searchModel);
        }
        public IActionResult OnGetCreate()
        {
            var command = new CreateProductPicture()
            {
                Products = _productApplication.GetProducts()
            };
            return Partial("./Create", command);
        }
        public JsonResult OnPostCreate(CreateProductPicture command)
        {
            var result = _productPictureApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var productPicture = _productPictureApplication.GetDetails(id);
            productPicture.Products = _productApplication.GetProducts();
            return Partial("Edit", productPicture);
        }

        public JsonResult OnPostEdit(EditProductPicture Command)
        {
            var result = _productPictureApplication.Edit(Command);
            return new JsonResult(result);
        }

        public IActionResult OnGetRemove(long id)
        {
            var result = _productPictureApplication.Remove(id);
           if (result.IsSucceeded)
               return RedirectToPage("./Index");
           Message = result.Message;
           return RedirectToPage("./Index");
           
        }
        public IActionResult OnGetRestore(long id)
        {
            var result = _productPictureApplication.Restore(id);
            if (result.IsSucceeded)
                return RedirectToPage("./Index");
            Message = result.Message;
            return RedirectToPage("./Index");

        }
    }
}
