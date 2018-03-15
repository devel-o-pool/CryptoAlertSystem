using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using System.Diagnostics;

namespace CryptoAlertSystem
{
    public partial class Dashboard : UserControl
    {

        private double currency1 = 0;
        private double currency2 = 0;
        private double currency3 = 0;
        private double currency4 = 0;
        private double currency5 = 0;

        public Dashboard()
        {
            InitializeComponent();

            var BTCPastRates = _download_serialized_json_data<HistoricalDataJSON>("https://min-api.cryptocompare.com/data/histoday?fsym=BTC&tsym=USD&limit=30");

            var LTCPastRates = _download_serialized_json_data<HistoricalDataJSON>("https://min-api.cryptocompare.com/data/histoday?fsym=LTC&tsym=USD&limit=30");

            var ETHPastRates = _download_serialized_json_data<HistoricalDataJSON>("https://min-api.cryptocompare.com/data/histoday?fsym=ETH&tsym=USD&limit=30");

            var DASHPastRates = _download_serialized_json_data<HistoricalDataJSON>("https://min-api.cryptocompare.com/data/histoday?fsym=DASH&tsym=USD&limit=30");

            var ZECPastRates = _download_serialized_json_data<HistoricalDataJSON>("https://min-api.cryptocompare.com/data/histoday?fsym=ZEC&tsym=USD&limit=30");

            int i = 0;


            while (i < BTCPastRates.Data.Length)
            {

                try
                {
                    currency1 = BTCPastRates.Data[i].close;
                    currency2 = LTCPastRates.Data[i].close;
                    currency3 = ETHPastRates.Data[i].close;
                    currency4 = DASHPastRates.Data[i].close;
                    currency5 = ZECPastRates.Data[i].close;

                }

                catch (Exception e)
                {
                    if (e.Equals("NullReferenceException"))
                        continue;
                }

                DashboardChart.Series["Bitcoin"].Points.AddY(currency1);
                DashboardChart.Series["Ethereum"].Points.AddY(currency2);
                DashboardChart.Series["Litecoin"].Points.AddY(currency3);
                DashboardChart.Series["Dash"].Points.AddY(currency4);
                DashboardChart.Series["Zec"].Points.AddY(currency5);

                i++;
            }
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

        private void DashboardChart_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePoint = new Point(e.X, e.Y);
            DashboardChart.ChartAreas["DashboardChartArea"].CursorX.SetCursorPixelPosition(mousePoint, true);
            DashboardChart.ChartAreas["DashboardChartArea"].CursorY.SetCursorPixelPosition(mousePoint, true);
        }
    }

    
}
