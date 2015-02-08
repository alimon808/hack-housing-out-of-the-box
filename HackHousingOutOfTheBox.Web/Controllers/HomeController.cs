//using SODA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using Esri.ArcGISRuntime.Tasks.Geocoding;
using Esri.ArcGISRuntime.Geometry;
using Esri.ArcGISRuntime.Tasks.Query;
using HackHousingOutOfTheBox.Services;
using Geocoding.Google;
using Geocoding;
using Newtonsoft.Json;

namespace HackHousingOutOfTheBox.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            GeocodingService geoCodingService = new GeocodingService();
            LocationInfo locationInfo = geoCodingService.Geocode("150 GRANDVIEW WAY MISSOULA MT");

            PublicHousingAuthorityInfoService phaiService = new PublicHousingAuthorityInfoService();
            // Hangs
            PublicHousingAuthorityInfo info = phaiService.GetPublicHousingAuthorityInfo(locationInfo.City, locationInfo.State);
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
