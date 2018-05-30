using RWA_Knjiga_MVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWA_Knjiga_MVC.Domain.Repositories
{
    public interface IPjesmeRepository
    {
        Pjesma CreateNew();
        Pjesma Get(int id);
        IEnumerable<Pjesma> GetAll();
        void Add(Pjesma item);
        void Delete(Pjesma item);
        void SaveAll();
        void Attach(Pjesma item);
    }
}
