using System;
using System.Collections.Generic;
using domain.entities.countries;
using DomainService = domain.domain.services.country;
using DomainCotract = domain.repositories.contracts.country;

namespace application.application.services.country
{
    public class CountryService : ICountryService
    {
        readonly DomainService.ICountryDomainService _domainIService;
        readonly DomainCotract.ICountryRepository _domainICotract;
        public CountryService(DomainService.ICountryDomainService domainICountryService, DomainCotract.ICountryRepository domainICotract)
        {
            this._domainIService = domainICountryService;
            this._domainICotract = domainICotract;
        }

        public void Create(City cityEntitie)
        {
            _domainICotract.Create(cityEntitie);
        }

        public void Delete(int id)
        {
            _domainICotract.Delete(id);
        }

        public List<City> GetCities()
        {
            return _domainICotract.GetCities();
        }

        public City GetCity(int id)
        {
            return _domainICotract.GetCity(id);
        }

        public string Hello()
        {
            return _domainIService.Hello();
        }

        public void Update(City cityEntitie)
        {
            _domainICotract.Update(cityEntitie);
        }
    }
}
