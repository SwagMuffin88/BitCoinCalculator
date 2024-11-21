using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace BitCoinCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currencySelector.SelectedItem.ToString() == "EUR")
            {
                resultLabel.Visible = true;
                tulemusLabel.Visible = true;
                BitcoinRates newBitcoinRate = GetRates();

                float result = float.Parse(bitcoinInput.Text) * (float)newBitcoinRate.Bpi.EUR.rate_float;

                resultLabel.Text = $"{result} Bitcoini {newBitcoinRate.Bpi.EUR.code}";
            }
        }
        public static BitcoinRates GetRates()
        {
            string url = "https://api.coindesk.com/v1/bpi/currentprice/currentprice.json";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            BitcoinRates bitcoin;

            using(var responseReader = new StreamReader(webStream)) 
            {
                var rates = responseReader.ReadToEnd();
                bitcoin = JsonConvert.DeserializeObject<BitcoinRates>(rates);
            }
            return bitcoin;
        }

    }
}
