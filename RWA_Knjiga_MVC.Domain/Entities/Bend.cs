using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWA_Knjiga_MVC.Domain.Entities
{
    public class Bend : EntityBase
    {
        public Bend()
        {
            this.Albumi = new List<Album>();
        }

        public string Naziv { get; set; }
        public int GodinaOsnutka { get; set; }
        public int BrojClanova { get; set; }

        public virtual List<Album> Albumi { get; set; }
    }
}
