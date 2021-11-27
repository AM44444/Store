using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Application;
using _0_FrameWork.Application;
using ShopManagement.Application.Contracts.Product;
using ShopManagement.Domain.Product;

namespace ShopManagement.Application
{
    public class ProductApplication : IProductApplication
    {
        private readonly IProductRepository _productRepository;

        public ProductApplication(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public OperationResult Create(CreateProduct command)
        {
            var operation = new OperationResult();
            if (_productRepository.Exists(x=>x.Name == command.Name))
            {
                return operation.Failed(ApplicationMessage.DuplicatedRecord);
            }
            else
            {
                var slug = command.Slug.Slugify();
                var product = new Product(command.Name, command.Code, command.UnitPrice, 
                    command.ShortDescription,
                    command.MetaDescription, command.Picture, command.PictureAlt,
                    command.PictureTitle, slug,
                    command.KeyWords, command.MetaDescription, command.CategoryId);
                _productRepository.Create(product);
                _productRepository.SaveChanges();
                return operation.Succeed();
            }
            
            
        }

        public OperationResult Edit(EditProduct command)
        {
            var operation = new OperationResult();
            var product = _productRepository.Get(command.Id);
            if (product == null)
            {
                return operation.Failed(ApplicationMessage.RecordNotFound);
            }
            else if (_productRepository.Exists(x=>x.Name == command.Name && x.Id != command.Id))
            {
                return operation.Failed(ApplicationMessage.RecordNotFound);
            }
            var slug = command.Slug.Slugify();
            product.Edit(command.Name, command.Code, command.UnitPrice,
                command.ShortDescription,
                command.MetaDescription, command.Picture, command.PictureAlt,
                command.PictureTitle, slug,
                command.KeyWords, command.MetaDescription, command.CategoryId);
            _productRepository.SaveChanges();
           return operation.Succeed();
        }

        public EditProduct GetDetails(long id)
        {
            return _productRepository.GetDetails(id);
        }

        public OperationResult IsInStock(long id)
        {
            var operation = new OperationResult();
            var product = _productRepository.Get(id);
            if (product == null)
            {
                return operation.Failed(ApplicationMessage.RecordNotFound);
            }
            else
            {
                product.InStock();
                _productRepository.SaveChanges();
                return operation.Succeed();
            }

        }

        public OperationResult IsNotInStock(long id)
        {
            var operation = new OperationResult();
            var product = _productRepository.Get(id);
            if (product == null)
            {
                return operation.Failed(ApplicationMessage.RecordNotFound);
            }
            else
            {
                product.NotInStock();
                _productRepository.SaveChanges();
                return operation.Succeed();
            }

        }

        public List<ProductViewModel> Search(ProductSearchModel searchModel)
        {
            return _productRepository.Search(searchModel);
        }
    }
}
