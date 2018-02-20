using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using System.Diagnostics;
using System.Threading;

namespace CryptoCurrencyApp
{

    public partial class Dashboard : Form
    {

        private Thread mainFormThread;
        private double[] currency1 = new double[3];
        private double[] currency2 = new double[3];
        String currency1URL = "https://api.cryptonator.com/api/ticker/btc-usd";
        String currency2URL = "https://api.cryptonator.com/api/ticker/eth-usd";

        public Dashboard()
        {
            InitializeComponent();
        }


        private void getRLTData()
        {

            while (true)
            {

                
                var currency1Rates = _download_serialized_json_data<Rootobject>(currency1URL);
                var currency2Rates = _download_serialized_json_data<Rootobject>(currency2URL);

                try
                {
                    //currency1[1] = Double.Parse(currency1Rates.ticker.price);
                    currency1[1] = currency1Rates.ticker.price;
                    currency1[0] = currency1Rates.timestamp;


                    //currency2[1] = Double.Parse(currency2Rates.ticker.price);
                    currency2[1] = currency2Rates.ticker.price;
                    currency2[0] = currency2Rates.timestamp;
                }

                catch(Exception e)
                {
                    if (e.Equals("NullReferenceException"))
                        continue;
                }

                if (dashboardChart.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate { UpdateChart(); });
                }

                else
                {

                }

                Thread.Sleep(10000);

            }


        }

        private void UpdateChart()
        {

            dashboardChart.Series["Series1"].Points.AddXY(currency1[0], currency1[1]);
            dashboardChart.Series["Series2"].Points.AddXY(currency2[0], currency2[1]);

        }

        private static T _download_serialized_json_data<T>(string url) where T : new()
        {
            using (WebClient w = new WebClient())
            {
                var json_data = string.Empty;
                // attempt to download JSON data as a string
                try
                {
                    json_data = w.DownloadString(url);
                    Debug.WriteLine(json_data);
                }
                catch (Exception exe) { Debug.WriteLine(exe.ToString()); }
                // if string with JSON data is not empty, deserialize it to class and return its instance 
                return !string.IsNullOrEmpty(json_data) ? JsonConvert.DeserializeObject<T>(json_data) : new T();
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {

            mainFormThread = new Thread(new ThreadStart(this.getRLTData));
            mainFormThread.IsBackground = true;
            mainFormThread.Start();
            Rootobject cp = new Rootobject();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cryptoCurrency11.Hide();
            cryptoCurrency11.SendToBack();
            cryptoCurrency21.Hide();
            cryptoCurrency21.SendToBack();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cryptoCurrency11.Show();
            cryptoCurrency11.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cryptoCurrency21.Show();
            cryptoCurrency21.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }


    public class Rootobject
    {
        public Ticker ticker { get; set; }
        public int timestamp { get; set; }
        public bool success { get; set; }
        public string error { get; set; }
    }

    public class Ticker
    {
        public string _base { get; set; }
        public string target { get; set; }
        public double price { get; set; }
        public string volume { get; set; }
        public string change { get; set; }
    }

}
