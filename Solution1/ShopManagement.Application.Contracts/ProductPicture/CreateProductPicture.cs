
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_FrameWork.Application;
using ShopManagement.Application.Contracts.Product;

namespace ShopManagement.Application.Contracts.ProductPicture
{
    public class CreateProductPicture
    {
        [Range(1,100000,ErrorMessage = ValidationMessage.IsRequired)]
        public long ProductId { get; set; }
        [Required( ErrorMessage= ValidationMessage.IsRequired)]
        public string Picture { get; set; }
        [Required(ErrorMessage = ValidationMessage.IsRequired)]
        public string PictureAlt { get; set; }
        [Required(ErrorMessage = ValidationMessage.IsRequired)]
        public string PictureTitle { get; set; }

        public List<ProductViewModel> Products { get; set; }

    }
}
