using System;
using System.Collections.Generic;
using domain.entities.countries;
using domain.repositories.contracts.country;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace infraestructure.repositories
{
    public class CountryRepository : ICountryRepository
    {
        private CountryDBContext _context;
        public CountryRepository(CountryDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void Create(City cityEntitie)
        {
            _context.Cities.Add(cityEntitie);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Cities.Remove(_context.Cities.Find(id));
            _context.SaveChanges();
        }

        public List<City> GetCities()
        {
            var query =
            from City in _context.Cities
            join State in _context.States on City.SateId equals State.Id
            select new { City, State };
            var x = query.ToList();
            return _context.Cities.ToList();

        }

        public City GetCity(int id)
        {
            var query =
            from City in _context.Cities
            join State in _context.States on City.SateId equals State.Id
            select new { City, State };
            var x = query.ToList();
            return _context.Cities.Find(id);
        }

        public void Update(City CityEntitie)
        {
            _context.Cities.Attach(CityEntitie);
            _context.Entry(CityEntitie).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
