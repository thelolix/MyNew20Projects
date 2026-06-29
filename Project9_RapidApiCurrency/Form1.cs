using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project9_RapidApiCurrency
{
    public partial class Form1 : Form
    {
        decimal dolar = 0;
        decimal euro = 0;
        decimal sterlin = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void  Form1_Load(object sender, EventArgs e)
        {
            #region Dolar
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=USD&to=TRY&amount=1"),
                Headers =
    {
        { "x-rapidapi-key", "e9ac376865msh728da4e7d43bf51p14186fjsnd35c251b7db4" },
        { "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var json = JObject.Parse(body);
                var value = json["result"].ToString();
                lblDollar.Text= value;
                dolar = decimal.Parse(value);
            }
            #endregion
            #region Euro
         
            var client2 = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=EUR&to=TRY&amount=1"),
                Headers =
    {
        { "x-rapidapi-key", "e9ac376865msh728da4e7d43bf51p14186fjsnd35c251b7db4" },
        { "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
    },
            };
            using (var response2 = await client2.SendAsync(request2))
            {
                response2.EnsureSuccessStatusCode();
                var body2 = await response2.Content.ReadAsStringAsync();
                var json2 = JObject.Parse (body2);
                var value2 = json2["result"].ToString();
                lblEuro.Text= value2;
                euro = decimal.Parse(value2);
            }
            #endregion
            #region Sterlin
         
            var client3 = new HttpClient();
            var request3 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=GBP&to=TRY&amount=1"),
                Headers =
    {
        { "x-rapidapi-key", "e9ac376865msh728da4e7d43bf51p14186fjsnd35c251b7db4" },
        { "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
    },
            };
            using (var response3 = await client.SendAsync(request3))
            {
                response3.EnsureSuccessStatusCode();
                var body3 = await response3.Content.ReadAsStringAsync();
                var json3  = JObject.Parse (body3);
                var value3 = json3["result"].ToString();
                lblSterlin.Text= value3;
                sterlin = decimal.Parse(value3);
            }




            #endregion

            txtTotalPrice.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal unitPrice = decimal.Parse(txtUnitPrice.Text);

            decimal totalPrice = 0;


            if (rdrDolar.Checked)
            {
                totalPrice = unitPrice * dolar;
            }
            else if (rdrEuro.Checked)
            {
                totalPrice = unitPrice * euro;

            }
            else 
            {
                totalPrice = unitPrice * sterlin;
            }
            txtTotalPrice.Text = totalPrice.ToString();
        
        }             
}
}
