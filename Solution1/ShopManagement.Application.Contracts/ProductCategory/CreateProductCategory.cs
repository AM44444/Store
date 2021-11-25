using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_FrameWork.Application;

namespace ShopManagement.Application.Contracts.ProductCategory
{
  public  class CreateProductCategory
    {
        [Required(ErrorMessage = ValidationMessage.IsRequired)]
        public string Name { get;  set; }
        public string Description { get;  set; }
        public string Picture { get;  set; }
        public string PictureAlt { get;  set; }
        public string PictureTitle { get;  set; }
        [Required(ErrorMessage = ValidationMessage.IsRequired)]

        public string Slug { get;  set; }
        [Required(ErrorMessage = ValidationMessage.IsRequired)]

        public string KeyWords { get;  set; }
        [Required(ErrorMessage = ValidationMessage.IsRequired)]

        public string MetaDescription { get;  set; }
    }
}
