using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarpetGallery.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetProducts(int CarpetCode)
        {
            switch (CarpetCode)
            {
                case 0:
                    return PartialView("/Views/Shared/_0_Home.cshtml");
                case 1:
                    return PartialView("/Views/Shared/_1_Products_Tabriz.cshtml");
                case 2:
                    return PartialView("/Views/Shared/_2_Products_Qom.cshtml");
                case 3:
                    return PartialView("/Views/Shared/_3_Products_Kashan.cshtml");
                case 4:
                    return PartialView("/Views/Shared/_4_AboutUs.cshtml");
                case 5:
                    return PartialView("/Views/Shared/_5_ContactUs.cshtml");
                default:
                    return PartialView("/Views/Shared/_Home.cshtml");
            }
        }
    }
}