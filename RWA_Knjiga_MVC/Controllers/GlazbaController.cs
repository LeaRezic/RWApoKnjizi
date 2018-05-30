using RWA_Knjiga_MVC.Domain.Repositories;
using RWA_Knjiga_MVC.Infrastructure;
using RWA_Knjiga_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RWA_Knjiga_MVC.Controllers
{
    public class GlazbaController : Controller
    {

        private IAlbumiRepository _albumiRepository = RepositoryFactory.GetAlbumiRepository();

        // GET: Glazba
        public ActionResult PjesmeNaAlbumu(int albumId)
        {
            var album = _albumiRepository.Get(albumId);

            var model = new PjesmeNaAlbumuModel();
            model.OdabraniAlbum = album;
            model.AlbumiOdabranogBenda = album.Bend.Albumi;
            model.PjesmeNaOdabranomAlbumu = album.Pjesme;
            return View(model);
        }
    }
}