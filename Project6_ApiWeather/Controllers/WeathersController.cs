using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project6_ApiWeather.Context;
using Project6_ApiWeather.Entities;

namespace Project6_ApiWeather.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeathersController : ControllerBase
    {

        WeatherContext context = new WeatherContext();

        [HttpGet]
        public IActionResult WeatherCityList()
        {
            var values = context.Cities.ToList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateWeatherCity(City city)
        {
            context.Cities.Add(city);
            context.SaveChanges();
            return Ok("Başarıyla eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteWeatherCity(int id)
        {
            var value = context.Cities.Find(id);
            context.Cities.Remove(value);
            context.SaveChanges();
            return Ok("Başarıyla silindi");
        }
        [HttpPut]
        public IActionResult UpdateWeatherCity(City city) {
            var value = context.Cities.Find(city.CityId);
            value.CityName = city.CityName;
            value.Country = city.Country;
            value.Detail = city.Detail;
            value.Temp = city.Temp;
            context.SaveChanges();
            return Ok("Başarıyla Güncellendi");
        }
        [HttpGet("GetByIdweatherCity")]
        public IActionResult GetByIdweatherCity(int id) 
        {
            var value = context.Cities.Find(id);
            return Ok(value);
        }

        [HttpGet("TotalCityCount")]
        public IActionResult TotalCitycount()
        {
            var value = context.Cities.Count();
            return Ok(value);
        }
        [HttpGet("MaxTempCityName")]
        public IActionResult MaxTempCityName()
        {
            var value = context.Cities.OrderByDescending(x=>x.Temp).Select(y=>y.CityName);
            return Ok(value);
        }
        [HttpGet("MinTempCityName")]
        public IActionResult MinTempCityName()
        {
            var value = context.Cities.OrderBy(x => x.Temp).Select(y => y.CityName);
            return Ok(value);
        }







    }
}
