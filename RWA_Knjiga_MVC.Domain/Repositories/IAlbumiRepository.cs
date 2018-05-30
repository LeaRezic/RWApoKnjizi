using RWA_Knjiga_MVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWA_Knjiga_MVC.Domain.Repositories
{
    public interface IAlbumiRepository
    {
        Album CreateNew();
        Album Get(int id);
        IEnumerable<Album> GetAll();
        void Add(Album item);
        void Delete(Album item);
        void SaveAll();
        void Attach(Album item);
    }
}
