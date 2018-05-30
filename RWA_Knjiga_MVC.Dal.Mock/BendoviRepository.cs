using RWA_Knjiga_MVC.Domain.Entities;
using RWA_Knjiga_MVC.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWA_Knjiga_MVC.Dal.Mock
{
    public class BendoviRepository : IBendoviRepository
    {
        public void Add(Bend item)
        {
            MockDatabase.Bendovi.Add(item);
        }

        public void Attach(Bend item)
        {
            throw new Exception("To be implemented later...");
        }

        public Bend CreateNew()
        {
            var item = new Bend
            {
                Id = MockDatabase.Bendovi.Max(x => x.Id) + 1
            };
            MockDatabase.Bendovi.Add(item);
            return item;

        }

        public void Delete(Bend item)
        {
            MockDatabase.Bendovi.Remove(item);
        }

        public Bend Get(int id)
        {
            return MockDatabase.Bendovi.Single(x => x.Id == id);
        }

        public IEnumerable<Bend> GetAll()
        {
            return MockDatabase.Bendovi;
        }

        public void SaveAll()
        {
        }
    }
}
