using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWA_Knjiga_MVC.Domain.Entities
{
    public class Album : EntityBase
    {
        public Album()
        {
            this.Pjesme = new List<Pjesma>();
        }

        public string Naziv { get; set; }
        public int GodinaIzdanja { get; set; }
        public decimal OsnovnaCijena { get; set; }
        public int BendId { get; set; }

        public virtual Bend Bend { get; set; }
        public virtual List<Pjesma> Pjesme { get; set; }
    }
}
