using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZarbiTtiTFA.DAL;
using ZarbiTtiTFA.Models;
using ZarbiTtiTFA.Repo;

namespace ZarbiTtiTFA.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public GenericUnitOfWork _unitOfWork = new GenericUnitOfWork();

        // Drop down list categories
        public List<SelectListItem> GetCategoria()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            var cat = _unitOfWork.GetRepositoryInstance<categoria>().GetAllRecords();
            foreach (var item in cat)
            {
                list.Add(new SelectListItem { Value = item.IDCategoria.ToString(), Text = item.nombreCategoria });
            }
            return list;
        }

        public ActionResult Dashboard()
        {
            return View();
        }
        /// <summary>
        /// Action para categorias 
        /// </summary>
        /// 
        public ActionResult Categorias()
        {
            List<categoria> categorias = _unitOfWork.GetRepositoryInstance<categoria>().GetAllRecordsIQueryable().Where(i => i.eliminado == false).ToList();
            
            return View(categorias);
        }
        public ActionResult AnyadirCategoria()
        {

            return UpdateCategoria(0);
        }
        public ActionResult UpdateCategoria(int categoriaID)
        {
            DetallesCategoria dc;
            if (categoriaID != null)
            {
                dc = JsonConvert.DeserializeObject<DetallesCategoria>(JsonConvert.SerializeObject(_unitOfWork.GetRepositoryInstance<categoria>().GetFirstorDefault(categoriaID)));
            }
            else
            {
                dc = new DetallesCategoria();
            }
            return View("UpdateCategoria", dc);
        }
        /*Editar categoria*/
        public ActionResult EditarCategoria(int categoriaId)
        {
            return View(_unitOfWork.GetRepositoryInstance<categoria>().GetFirstorDefault(categoriaId));
        }
        [HttpPost]
        public ActionResult EditarCategoria(categoria cat)
        {
            _unitOfWork.GetRepositoryInstance<categoria>().Update(cat);
            return RedirectToAction("Categorias");
        }

        //Return product
        public ActionResult Producto()
        {
            return View(_unitOfWork.GetRepositoryInstance<producto>().GetProducto());
        }

        /*Editar producto*/
        public ActionResult EditarProducto(int productoId)
        {
            ViewBag.ListaDeCategoria = GetCategoria();
            return View(_unitOfWork.GetRepositoryInstance<producto>().GetFirstorDefault(productoId));
        }
        [HttpPost]
        public ActionResult EditarProducto(producto prod, HttpPostedFileBase file)
        {
            string pic = null;
            if (file != null)
            {
                pic = System.IO.Path.GetFileName(file.FileName);
                string path = System.IO.Path.Combine(Server.MapPath("~/ProductImg"), pic);
                // file is uploaded
                file.SaveAs(path);
            }
            prod.ProductImage = file != null ? pic : prod.ProductImage;
            prod.fechaDeModificacion = DateTime.Now;
            _unitOfWork.GetRepositoryInstance<producto>().Update(prod);
            return RedirectToAction("Producto");
        }

        public ActionResult AnyadirProducto()
        {
            ViewBag.ListaDeCategoria = GetCategoria();
            return View();
        }

        [HttpPost]
        public ActionResult AnyadirProducto(producto prod, HttpPostedFileBase file)
        {
            string pic = null;
            if (file != null)
            {
                pic = System.IO.Path.GetFileName(file.FileName);
                string path = System.IO.Path.Combine(Server.MapPath("~/ProductImg"), pic);
                // file is uploaded
                file.SaveAs(path);
            }
            prod.ProductImage = pic;
            
            prod.fechaDeCreacion = DateTime.Now;
            _unitOfWork.GetRepositoryInstance<producto>().Add(prod);
            return RedirectToAction("Producto");
        }
    }
}