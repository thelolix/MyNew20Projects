






#region Menü İşlemleri

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Text.Json.Nodes;

Console.WriteLine("Api Consume İşlemine Hoş Geldiniz");
Console.WriteLine();
Console.WriteLine("#### Yapmak istediginiz işlemi seciniz  ####");
Console.WriteLine();
Console.WriteLine("1-Şehir Listesini Getirin");
Console.WriteLine("2-Şehir ve Hava Durumunu Getirin");
Console.WriteLine("3-Yeni Şehir Ekleme");
Console.WriteLine("4-Şehir Silme İşlemleri");
Console.WriteLine("5-Şehir Güncelleme İşlemleri");
Console.WriteLine("6-ID'ye Göre Şehir Getirme");
Console.WriteLine();
#endregion

String number;

Console.Write("Tercihinizi Seçiniz: ");
number = Console.ReadLine();

if (number == "1")
{
    string url = "https://localhost:7222/api/Weathers";
    using (HttpClient client = new HttpClient())
    {
        HttpResponseMessage responseMessage = await client.GetAsync(url);
        string responseBody = await responseMessage.Content.ReadAsStringAsync();
        JArray jArray = JArray.Parse(responseBody);
        foreach (var item in jArray)
        {
            string cityName = item["cityName"].ToString();
            Console.WriteLine($"Şehir: {cityName}");
        }
    }
}
else if (number == "2")
{
    String url = "https://localhost:7222/api/Weathers";
    using (HttpClient client = new HttpClient())
    {
        HttpResponseMessage responseMessage = await client.GetAsync(url);
        string responseBody = await responseMessage.Content.ReadAsStringAsync();
        JArray jArray = JArray.Parse(responseBody);
        foreach (var item in jArray)
        {
            string cityName = item["cityName"].ToString();
            string temp = item["temp"].ToString();
            string country = item["country"].ToString();
            Console.WriteLine(cityName + "-" + temp + "-" + country);
            Console.WriteLine("--------------------------------------");
        }
    }
}
else if (number == "3")
{

    Console.WriteLine("#### Yeni Veri Girişi ####");
    Console.WriteLine();
    string cityName, country, detail;
    decimal temp;

    Console.Write("Şehir Adı: ");
    cityName = Console.ReadLine();

    Console.Write("Ülke Adı: ");
    country = Console.ReadLine();

    Console.Write("Hava Durmu Detayı: ");
    detail = Console.ReadLine();

    Console.Write("Hava Sıcaklıgı: ");
    temp = decimal.Parse(Console.ReadLine());


    String url = "https://localhost:7222/api/Weathers";
    var newWeatherCity = new
    {
        CityName = cityName,
        Country = country,
        Detail = detail,
        Temp = temp
    };
    using (HttpClient client = new HttpClient())
    {

        string json = JsonConvert.SerializeObject(newWeatherCity);
        StringContent content = new StringContent(json,Encoding.UTF8,"application/json");
        HttpResponseMessage responseMessage =await client.PostAsync(url, content);
        responseMessage.EnsureSuccessStatusCode();

    }










Console.Read();
}
else if (number == "4")
{
    //apinin adersine iyi bak
    string url ="https://localhost:7222/api/Weathers?id=";
    Console.Write("Silmek İstediginiz ID'yi Girin: ");
    int id =int.Parse(Console.ReadLine());

    using(HttpClient client = new HttpClient())
    {
        HttpResponseMessage responseMessage = await client.DeleteAsync(url+id);
        responseMessage.EnsureSuccessStatusCode();
    }

}
else if (number == "5")
{
    Console.WriteLine("Güncelleme İşlemleri");
    Console.WriteLine();
    string cityName, country, detail;
    decimal temp;
    int id;

    Console.Write("Şehir Adı: ");
    cityName = Console.ReadLine();

    Console.Write("Ülke Adı: ");
    country= Console.ReadLine();

    Console.Write("Hava Durmu: ");
    detail = Console.ReadLine();

    Console.Write("sıcaklık: ");
    temp =decimal.Parse(Console.ReadLine());

    Console.Write("Şehir Id: ");
    id = int.Parse(Console.ReadLine());

    String url = "https://localhost:7222/api/Weathers";
    var updateWeatherValues = new
    {
        CityName = cityName,
        Country = country,
        Detail = detail,
        Temp = temp,


    };
    using (HttpClient client = new HttpClient())
    {
        string json = JsonConvert.SerializeObject(updateWeatherValues);
        StringContent content = new StringContent(json,Encoding.UTF8,"application/json");
        HttpResponseMessage responseMessage = await client.PutAsync(url, content);
        responseMessage.EnsureSuccessStatusCode() ;

    }
}
else
{
    string url = "https://localhost:7222/api/Weathers/GetByIdweatherCity?id=";

    Console.Write("bilgilerini Getirmek İstediginiz Id Degeri: ");
    int id = int.Parse(Console.ReadLine());

    using (HttpClient client = new HttpClient())
    {
        HttpResponseMessage responseMessage = await client.GetAsync(url + id);
        responseMessage.EnsureSuccessStatusCode();
        string responBody = await responseMessage.Content.ReadAsStringAsync();
        JObject weatherCityObjcet = JObject.Parse(responBody);

        string cityName = weatherCityObjcet["cityName"].ToString();
        string detail = weatherCityObjcet["detail"].ToString();
        string country = weatherCityObjcet["country"].ToString();
        decimal temp = decimal.Parse(weatherCityObjcet["temp"].ToString());

        Console.WriteLine("Girmiş oldugunuz ıd degerlerine ait bilgiler");
        Console.WriteLine();
        Console.WriteLine("Şehir: " + cityName + "Ülke: " + country + "Detay: " + detail + "Sıcaklık: " + temp  );


    }
}
