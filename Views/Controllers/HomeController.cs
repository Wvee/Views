using Microsoft.AspNetCore.Mvc;

namespace Views.Controllers
{
    public class HomeController : Controller
    {
        //public ViewResult Index()
        //{
        //    ViewBag.Message = "Hello world";
        //    ViewBag.Time = DateTime.Now.ToString("HH:mm:ss");
        //    return View("DebugData");
        //}
        //public ViewResult List()
        //{
        //    return View();
        //}

        public ViewResult Index()
        {
            return View("MyView",new string[] { "Apple", "Orange", "Pear" });
        }

        public ViewResult List()
        {
            return View("Views/Common/List.cshtml");
        }
    }
}
