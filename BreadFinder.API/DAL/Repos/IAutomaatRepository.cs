using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BreadFinder.API.DAL.ENT;

namespace BreadFinder.API.DAL.Repos
{
    public interface IAutomaatRepository
    {
        Automaat GetById(int id);
        IEnumerable<Automaat> GetAll();
        IEnumerable<Automaat> GetByGemeente(string gemeente);
        IEnumerable<Automaat> GetByProvincie(string provincie);

        void Add(Automaat automaat);
        void Update(Automaat automaat);
        void Delete(int id);
    }
}
