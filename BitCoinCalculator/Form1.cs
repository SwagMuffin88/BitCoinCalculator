﻿using System;
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
            convertResult.Visible = true;
            convertResultLabel.Visible = true;
            BitcoinRates newBitcoinRate = GetRates();

            float result = 0;

            switch (currencySelector.SelectedItem.ToString())
            {
                case "EUR" :
                    result = float.Parse(bitcoinInput.Text) * (float)newBitcoinRate.Bpi.EUR.rate_float;
                    convertResult.Text = $"{result} {newBitcoinRate.Bpi.EUR.code}";
                    break;
                
                case "USD":
                    result = float.Parse(bitcoinInput.Text) * (float)newBitcoinRate.Bpi.USD.rate_float;
                    convertResult.Text = $"{result} {newBitcoinRate.Bpi.USD.code}";
                    break;
                
                case "GBP":
                    result = float.Parse(bitcoinInput.Text) * (float)newBitcoinRate.Bpi.GBP.rate_float;
                    convertResult.Text = $"{result} {newBitcoinRate.Bpi.GBP.code}";
                    break;
                
                case "EEK":
                    result = float.Parse(bitcoinInput.Text) * (float)newBitcoinRate.Bpi.EUR.rate_float * 15.6466f;
                    convertResult.Text = $"{result} EEK";
                    break;
                    
            }
            
            // if (currencySelector.SelectedItem.ToString() == "EUR")
            // {
            //     result = float.Parse(bitcoinInput.Text) * (float)newBitcoinRate.Bpi.EUR.rate_float;
            //
            //     convertResult.Text = $"{result} Bitcoini {newBitcoinRate.Bpi.EUR.code}";
            // }
            // else if (currencySelector.SelectedItem.ToString() == "USD")
            // {
            //     result = float.Parse(bitcoinInput.Text) * (float)newBitcoinRate.Bpi.USD.rate_float;
            //
            //     convertResult.Text = $"{result} Bitcoini {newBitcoinRate.Bpi.USD.code}";
            // }
        }
        public static BitcoinRates GetRates()
        {
            string url = "https://api.coindesk.com/v1/bpi/currentprice.json";

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
