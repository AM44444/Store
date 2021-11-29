using System;
using System.Collections.Generic;
using _0_Framework.Application;
using _0_FrameWork.Application;
using ShopManagement.Application.Contracts.ProductCategory;
using ShopManagement.Domain.ProductCategoryAgg;

namespace ShopManagement.Application
{
    public class ProductCategoryApplication:IProductCategoryApplication
    {
        private readonly IProductCategoryRepository _productCategoryRepository;

        public ProductCategoryApplication(IProductCategoryRepository productCategoryRepository)
        {
            _productCategoryRepository = productCategoryRepository;
        }


        public OperationResult Create(CreateProductCategory Command)
        {
            var operationResult = new OperationResult();
            if (_productCategoryRepository.Exists(x=>x.Name == Command.Name))
                return operationResult.Failed(ApplicationMessage.DuplicatedRecord);
            var slug = Command.Slug.Slugify();
            var productCategory = new ProductCategory(Command.Name, Command.Description
                , Command.Picture, Command.PictureAlt, Command.PictureTitle, slug
                , Command.KeyWords, Command.MetaDescription);
             _productCategoryRepository.Create(productCategory);
             _productCategoryRepository.SaveChanges();
             return operationResult.Succeed();
        }

        public OperationResult Edit(EditProductCategory Command)
        {
            var operation = new OperationResult();
            var productCategory = _productCategoryRepository.Get(Command.Id);
            if (productCategory== null)
            {
                return operation.Failed(ApplicationMessage.RecordNotFound);
            }
            else if(_productCategoryRepository.Exists(x=>x.Name==Command.Name && x.Id != Command.Id))
            {
                return operation.Failed(ApplicationMessage.RecordNotFound);
            }
            var slug = Command.Slug.Slugify();
            productCategory.Edit(Command.Name, Command.Description
                , Command.Picture, Command.PictureAlt, Command.PictureTitle, slug
                , Command.KeyWords, Command.MetaDescription);
            _productCategoryRepository.SaveChanges();
            return operation.Succeed();
        }

        public EditProductCategory GetDetails(long Id)
        {
            return _productCategoryRepository.GetDetails(Id);
        }

        public List<ProductCategoryViewModel> GetProductCategories()
        {
            return _productCategoryRepository.GetProductCategories();
        }

        public List<ProductCategoryViewModel> Search(ProductCategorySearchModel SearchModel)
        {
            return _productCategoryRepository.Search(SearchModel);
        }

      

       
    }
}
