using System;
using System.Collections.Generic;
using domain.entities.countries;

namespace application.application.services.country
{
    public interface ICountryService
    {
        string Hello();
        void Create(City cityEntitie);
        void Update(City cityEntitie);
        void Delete(int id);
        City GetCity(int id);
        List<City> GetCities();
    }
}
