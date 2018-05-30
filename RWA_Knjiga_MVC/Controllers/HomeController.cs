using RWA_Knjiga_MVC.Domain.Repositories;
using RWA_Knjiga_MVC.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RWA_Knjiga_MVC.Controllers
{
    public class HomeController : Controller
    {

        private IBendoviRepository _bendoviRepository = RepositoryFactory.GetBendoviRepository();

        public ActionResult Index(int id = -1)
        {
            if (id == -1)
            {
                return View();
            }
            try
            {
                var bend = _bendoviRepository.Get(id);
                return Content($"Traženi bend je: {bend.Naziv}");
                //return View(bend);
            }
            catch (Exception)
            {
                return Content("Nema traženog benda");
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}