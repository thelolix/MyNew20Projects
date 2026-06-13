namespace Project6_ApiWeather.Entities
{
    public class City
    {
        public int CityId { get; set; }

        public String CityName { get; set; }
        public String Country  { get; set; }

        public decimal Temp { get; set; }
        public String Detail { get; set; }
    }
}
