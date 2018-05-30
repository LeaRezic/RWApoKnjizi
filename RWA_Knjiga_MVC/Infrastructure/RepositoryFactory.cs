using RWA_Knjiga_MVC.Dal.Mock;
using RWA_Knjiga_MVC.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RWA_Knjiga_MVC.Infrastructure
{
    public static class RepositoryFactory
    {
        private static bool _useMock = true;

        public static IAlbumiRepository GetAlbumiRepository()
        {
            if (_useMock)
            {
                return new AlbumiRepository();
            }
            else
            {
                throw new NotImplementedException("Implement me...");
            }
        }

        public static IBendoviRepository GetBendoviRepository()
        {
            if (_useMock)
            {
                return new BendoviRepository();
            }
            else
            {
                throw new NotImplementedException("Implement me...");
            }
        }

        public static IPjesmeRepository GetPjesmeRepository()
        {
            if (_useMock)
            {
                return new PjesmeRepository();
            }
            else
            {
                throw new NotImplementedException("Implement me...");
            }
        }
    }
}