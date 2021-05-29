using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZarbiTtiTFA.Models.Moderna;

namespace ZarbiTtiTFA.Controllers
{
    public class ModernaController : Controller
    {
        // GET: Moderna
        public ActionResult Index()
        {
            ModernaIndexViewModel model = new ModernaIndexViewModel();
            return View(model.createModel());
            
        }
    }
}