using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_TennisQuery.Contract.Product;
using Microsoft.AspNetCore.Mvc;

namespace ServicesHost.ViewComponents
{
    public class LatestArrivalsViewComponent:ViewComponent
    {
        private readonly IProductQuery _productQuery;

        public LatestArrivalsViewComponent(IProductQuery productQuery)
        {
            _productQuery = productQuery;
        }

        public IViewComponentResult Invoke()
        {
            var products = _productQuery.GetLatestArrivals();
            return View(products);
        }
    }
}
