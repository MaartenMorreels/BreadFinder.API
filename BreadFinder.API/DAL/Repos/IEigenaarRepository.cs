using BreadFinder.API.DAL.ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BreadFinder.API.DAL.Repos
{
    public interface IEigenaarRepository
    {
        IEnumerable<Eigenaar> GetAll();
        Eigenaar GetEigenaarById(int eigenaarId);
        IEnumerable<Eigenaar> GetEigenaarsByNaam(string eigenaarNaam);
        void Add(Eigenaar eigenaar);
        void Update(Eigenaar eigenaar);
        void Delete(int eigenaarId);
    }
}
