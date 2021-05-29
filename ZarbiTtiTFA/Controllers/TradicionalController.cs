using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZarbiTtiTFA.DAL;
using ZarbiTtiTFA.Models.Tradicional;

namespace ZarbiTtiTFA.Controllers
{
    public class TradicionalController : Controller
    {
        zarbittiDBEntities context = new zarbittiDBEntities();
        // GET: Tradicional
        public ActionResult Index(int idProducto)
        {
            TradicionalIndexViewModel model = new TradicionalIndexViewModel();
            return View(model.createModel());
        }

        public ActionResult AnyadirCarro(int idProducto)
        {
            var carro = new List<Item>();
            var producto = context.producto.Find(idProducto);

            carro.Add(new Item()
            {
                pro = producto,
                cantidad = 1
            });
            Session["carro"] = carro;
            return Redirect("Index");
        }

    }
}