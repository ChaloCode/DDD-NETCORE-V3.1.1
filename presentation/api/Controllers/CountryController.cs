using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using application.application.services.country;
using domain.entities.countries;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountryController : ControllerBase
    {
        private readonly ICountryService _iCountryService;

        private readonly ILogger<CountryController> _logger;        

        public CountryController(ICountryService iCountryService, ILogger<CountryController> logger)
        {
            this._iCountryService = iCountryService;
            _logger = logger;
        }

        [HttpGet]
        public List<City> Get()
        {
            List<City> response = new List<City>();
            try
            {
                response = _iCountryService.GetCities();

            }
            catch (System.Exception e)
            {
                _logger.LogInformation(e.Message);
            }
            return response;
        }

        [HttpGet("{id}")]
        public City Get(int id)
        {
            City response = new City();
            try
            {
                response = _iCountryService.GetCity(id);

            }
            catch (System.Exception e)
            {
                _logger.LogInformation(e.Message);
            }
            return response;
        }

        [HttpPost]
        public void Post([FromBody] City city)
        {
            try
            {
                _iCountryService.Create(city);
            }
            catch (System.Exception e)
            {
                _logger.LogInformation(e.Message);
            }
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] City city)
        {
            try
            {
                City _city = new City();
                _city = city;
                _city.Id = id;
                _iCountryService.Update(_city);
            }
            catch (System.Exception e)
            {
                _logger.LogInformation(e.Message);
            }

        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            try
            {
                _iCountryService.Delete(id);
            }
            catch (System.Exception e)
            {
                _logger.LogInformation(e.Message);
            }
        }

    }
}
