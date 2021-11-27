using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_FrameWork.Application;

namespace ShopManagement.Application.Contracts.Product
{
  public  interface IProductApplication
  {
      OperationResult Create(CreateProduct command);
      OperationResult Edit(EditProduct command);
      OperationResult IsInStock(long id);
      OperationResult IsNotInStock(long id);
      EditProduct GetDetails(long id);
      List<ProductViewModel> Search(ProductSearchModel searchModel);
  }
}
