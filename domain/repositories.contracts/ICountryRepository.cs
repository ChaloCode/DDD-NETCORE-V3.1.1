using System;
using System.Collections.Generic;
using domain.entities.countries;

namespace domain.repositories.contracts.country
{
    public interface ICountryRepository
    {
        void Create(City carEntitie);
        void Update(City carEntitie);
        void Delete(int id);
        City GetCity(int id);
        List<City> GetCities();
    }
}
