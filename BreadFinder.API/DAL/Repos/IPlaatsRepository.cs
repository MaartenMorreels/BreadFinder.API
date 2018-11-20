using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BreadFinder.API.DAL.ENT;

namespace BreadFinder.API.DAL.Repos
{
    public interface IPlaatsRepository
    {
        Plaats GetById(int id);
        IEnumerable<Plaats> GetAll();
        IEnumerable<Plaats> GetByPlaatsNaam(string plaatsnaam);

        void Add(Plaats plaats);
        void Update(Plaats plaats);
        void Delete(int id);

    }
}
