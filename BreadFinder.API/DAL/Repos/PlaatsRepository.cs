using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BreadFinder.API.DAL.ENT;
using Microsoft.EntityFrameworkCore;

namespace BreadFinder.API.DAL.Repos
{
    public class PlaatsRepository : IPlaatsRepository
    {
        private readonly BreadFinderContext _context;

        public PlaatsRepository(BreadFinderContext context)
        {
            _context = context;
        }

        public Plaats GetById(int id)
        {
            return _context.Plaats.Find(id);
        }

        public IEnumerable<Plaats> GetAll()
        {
            return _context.Plaats.ToList();
        }

        public void Add(Plaats plaats)
        {
            _context.Plaats.Add(plaats);
            _context.SaveChanges();
        }

        public void Update(Plaats plaats)
        {
            _context.Entry(plaats).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Plaats plaats = _context.Plaats.Find(id);
            _context.Plaats.Remove(plaats);
            _context.SaveChanges();
        }

        public IEnumerable<Plaats> GetByPlaatsNaam(string plaatsnaam)
        {
            var plaatsen = _context.Plaats
                .Where(p => p.PlaatsNaam.ToLower() == plaatsnaam.ToLower())
                .ToList();
            return plaatsen;
        }
    }
}
