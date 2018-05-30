using RWA_Knjiga_MVC.Domain.Entities;
using RWA_Knjiga_MVC.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWA_Knjiga_MVC.Dal.Mock
{
    public class AlbumiRepository : IAlbumiRepository
    {
        public void Add(Album item)
        {
            MockDatabase.Albumi.Add(item);
        }

        public void Attach(Album item)
        {
            throw new Exception("To be implemented later...");
        }

        public Album CreateNew()
        {
            var item = new Album
            {
                Id = MockDatabase.Albumi.Max(x => x.Id) + 1
            };
            MockDatabase.Albumi.Add(item);
            return item;

        }

        public void Delete(Album item)
        {
            MockDatabase.Albumi.Remove(item);
        }

        public Album Get(int id)
        {
            return MockDatabase.Albumi.Single(x => x.Id == id);
        }

        public IEnumerable<Album> GetAll()
        {
            return MockDatabase.Albumi;
        }

        public void SaveAll()
        {
        }
    }
}
