using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BreadFinder.API.DAL.ENT;
using Microsoft.EntityFrameworkCore;

namespace BreadFinder.API.DAL.Repos
{
    public class AutomaatRepository : IAutomaatRepository
    {
        private readonly BreadFinderContext _context;

        public AutomaatRepository(BreadFinderContext context)
        {
            _context = context;
        }

        public IEnumerable<Automaat> GetAll()
        {
            return _context.Automaat
                .Include(a => a.Plaats)
                .Include(a => a.Eigenaar)
                    .ThenInclude(e => e.Plaats)
                .ToList();
        }

        public Automaat GetById(int id)
        {
            var automaat = _context.Automaat
                .Where(a => a.Id == id)
                .Include(a => a.Plaats)
                .Include(a => a.Eigenaar)
                    .ThenInclude(e => e.Plaats)
                .FirstOrDefault();
            return automaat;
        }

        public IEnumerable<Automaat> GetByGemeente(string plaatsnaam)
        {
            var automaten = _context.Automaat
                .Where(a => a.Plaats.PlaatsNaam == plaatsnaam)
                .Include(a => a.Plaats)
                .Include(a => a.Eigenaar)
                    .ThenInclude(e => e.Plaats)
                .ToList();
            return automaten;
        }

        public IEnumerable<Automaat> GetByProvincie(string provincie)
        {
            var automaten = _context.Automaat
                .Where(a => a.Plaats.Provincie.ToLower() == provincie.ToLower())
                .Include(a => a.Plaats)
                .Include(a => a.Eigenaar)
                    .ThenInclude(e => e.Plaats)
                .ToList();
            return automaten;
        }


        public void Add(Automaat automaat)
        {
            _context.Automaat.Add(automaat);
            _context.SaveChanges();
        }

        public void Update(Automaat automaat)
        {
                _context.Automaat.Update(automaat);
                _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Automaat automaat = _context.Automaat.Find(id);
            _context.Automaat.Remove(automaat);
            _context.SaveChanges();
        }

    }
}
