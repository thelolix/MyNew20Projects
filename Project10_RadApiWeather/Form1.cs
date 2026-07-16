using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Windows.Forms;

namespace Project10_RadApiWeather
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://open-weather13.p.rapidapi.com/fivedaysforcast?latitude=40.730610&longitude=-73.935242&lang=TR"),
                Headers =
                {
                    { "x-rapidapi-key", "e9ac376865msh728da4e7d43bf51p14186fjsnd35c251b7db4" },
                    { "x-rapidapi-host", "open-weather13.p.rapidapi.com" },
                },
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var json = JObject.Parse(body);
                var cityName = json["city"].ToString();
                var temp = json["list"][0]["main"]["temp"].ToString();
                txtCity.Text = cityName;
                lblWeatherCity.Text = temp;
            }
        }
    }
}




