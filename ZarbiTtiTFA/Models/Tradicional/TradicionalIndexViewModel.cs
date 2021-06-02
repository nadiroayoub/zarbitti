using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZarbiTtiTFA.DAL;
using ZarbiTtiTFA.Repo;

namespace ZarbiTtiTFA.Models.Tradicional
{
    public class TradicionalIndexViewModel
    {
        public GenericUnitOfWork _unitOfWork = new GenericUnitOfWork();
        public IEnumerable<producto> listaDeProductos { get; set; }
        public TradicionalIndexViewModel createModel()
        {
            return new TradicionalIndexViewModel()
            {
                listaDeProductos = _unitOfWork.GetRepositoryInstance<producto>().GetAllRecords()
            };
        }
    }
}