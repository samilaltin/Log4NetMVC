using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using log4net.Config;

namespace Log4NetMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger logger;
        public HomeController()
        {
            XmlConfigurator.Configure();
            this.logger = new Logger(this.GetType().FullName);
        }
        public ActionResult Index()
        {
          
            logger.Info("HOME");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            logger.Info("ABOUT");

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            logger.Info("CONTACT");

            return View();
        }
    }
}