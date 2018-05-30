using RWA_Knjiga_MVC.Domain.Entities;
using RWA_Knjiga_MVC.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWA_Knjiga_MVC.Dal.Mock
{
    public class PjesmeRepository : IPjesmeRepository
    {
        public void Add(Pjesma item)
        {
            MockDatabase.Pjesme.Add(item);
        }

        public void Attach(Pjesma item)
        {
            throw new Exception("To be implemented later...");
        }

        public Pjesma CreateNew()
        {
            var item = new Pjesma
            {
                Id = MockDatabase.Pjesme.Max(x => x.Id) + 1
            };
            MockDatabase.Pjesme.Add(item);
            return item;

        }

        public void Delete(Pjesma item)
        {
            MockDatabase.Pjesme.Remove(item);
        }

        public Pjesma Get(int id)
        {
            return MockDatabase.Pjesme.Single(x => x.Id == id);
        }

        public IEnumerable<Pjesma> GetAll()
        {
            return MockDatabase.Pjesme;
        }

        public void SaveAll()
        {
        }

    }
}
