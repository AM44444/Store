using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_TennisQuery.Contract.Slide;
using Microsoft.AspNetCore.Mvc;

namespace ServicesHost.ViewComponents
{
    public class FooterViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            
            return View();
        }
    }
}
