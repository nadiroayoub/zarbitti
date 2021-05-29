using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZarbiTtiTFA.DAL;
using ZarbiTtiTFA.Repo;

namespace ZarbiTtiTFA.Models.Moderna
{
    public class ModernaIndexViewModel
    {
        public GenericUnitOfWork _unitOfWork = new GenericUnitOfWork();
        public IEnumerable<producto> listaDeProductos { get; set; }
        public ModernaIndexViewModel createModel()
        {
            return new ModernaIndexViewModel()
            {
                listaDeProductos = _unitOfWork.GetRepositoryInstance<producto>().GetAllRecords()

            };
        }
    }
}