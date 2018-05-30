using RWA_Knjiga_MVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RWA_Knjiga_MVC.Models
{
    public class PjesmeNaAlbumuModel
    {
        public PjesmeNaAlbumuModel()
        {
            AlbumiOdabranogBenda = new List<Album>();
            PjesmeNaOdabranomAlbumu = new List<Pjesma>();
        }

        public Album OdabraniAlbum { get; set; }
        public List<Album> AlbumiOdabranogBenda { get; set; }
        public List<Pjesma> PjesmeNaOdabranomAlbumu { get; set; }
    }
}