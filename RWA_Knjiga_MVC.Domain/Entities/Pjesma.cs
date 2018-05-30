using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWA_Knjiga_MVC.Domain.Entities
{
    public class Pjesma : EntityBase
    {
        public string Naziv { get; set; }
        public int RedniBroj { get; set; }
        public int TrajanjeSekundi { get; set; }
        public int AlbumId { get; set; }

        public Album Album { get; set; }
    }
}
