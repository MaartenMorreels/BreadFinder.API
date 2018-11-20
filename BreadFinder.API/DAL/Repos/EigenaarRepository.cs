using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BreadFinder.API.DAL.ENT;
using Microsoft.EntityFrameworkCore;

namespace BreadFinder.API.DAL.Repos
{
    public class EigenaarRepository : IEigenaarRepository
    {
        private readonly BreadFinderContext _context;

        public EigenaarRepository(BreadFinderContext context)
        {
            _context = context;
        }

        public IEnumerable<Eigenaar> GetAll()
        {
            var eigenaars = _context.Eigenaar.ToList();
            return eigenaars;
        }

        public Eigenaar GetEigenaarById(int eigenaarId)
        {
            var eigenaar = _context.Eigenaar.Find(eigenaarId);
            return eigenaar;
        }

        public IEnumerable<Eigenaar> GetEigenaarsByNaam(string eigenaarNaam)
        {
            var eigenaarsMetZelfdeNaam = _context.Eigenaar
                .Include("Plaats")
                .Where(e => e.Naam.ToLower() == eigenaarNaam.ToLower())
                .ToList();
            return eigenaarsMetZelfdeNaam;
        }

        public void Add(Eigenaar eigenaar)
        {
            _context.Eigenaar.Add(eigenaar);
            _context.SaveChanges();
        }

        public void Update(Eigenaar eigenaar)
        {
            _context.Entry(eigenaar).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Eigenaar eigenaar = _context.Eigenaar.Find(id);
            _context.Eigenaar.Remove(eigenaar);
            _context.SaveChanges();
        }

    }
}