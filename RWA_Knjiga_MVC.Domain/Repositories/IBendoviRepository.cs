using RWA_Knjiga_MVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWA_Knjiga_MVC.Domain.Repositories
{
    public interface IBendoviRepository
    {
        Bend CreateNew();
        Bend Get(int id);
        IEnumerable<Bend> GetAll();
        void Add(Bend item);
        void Delete(Bend item);
        void SaveAll();
        void Attach(Bend item);
    }
}
