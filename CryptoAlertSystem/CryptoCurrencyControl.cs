using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Newtonsoft.Json;
using System.Net;
using System.Diagnostics;

namespace CryptoAlertSystem
{
    public partial class CryptoCurrencyControl : UserControl
    {
        private Thread cryptoCurrency2Thread;

        GET get = new GET();

        //Values for storing the data retrieved from the API
        private double currentValue = 0;
        private String currencyURL = "";
        private double currentHigh = 0;
        private double currentLow = 99999999;
        private double userDefinedHigh = 99999999;
        private double userDefinedLow = 0;
        private double userDefinedDifference = 0;
        private bool isRising = false;
        private double previousValue = 0;
        private char currencyType = 'e';

        public CryptoCurrencyControl()
        {
            InitializeComponent();

            //Initialize each tab with a default cryptocurrency
            currencyURL = get.URL(currencyType);
            CryptoCurrencyChart.ChartAreas["CryptoCurrencyChartArea"].AxisY.IsStartedFromZero = false;
            
        }

        //Retreives data from the API, with the help of a loop
        private void getRLTData()
        {

            while (true)
            {

                //uses Newtonsoft.JSON framework to serialize the data
                var currency2Rates = _download_serialized_json_data<JSONStructure>(currencyURL);

                //get the current value of the cryptocurrency
                try
                {
                    //changes the url depending upon the currentValue that the user has picked
                    if (currencyType == 'e')
                        currentValue = currency2Rates.ETH.USD;
                    else if (currencyType == 'b')
                        currentValue = currency2Rates.BTC.USD;
                    else if (currencyType == 'l')
                        currentValue = currency2Rates.LTC.USD;
                    else if (currencyType == 'd')
                        currentValue = currency2Rates.DASH.USD;
                    else if (currencyType == 'z')
                        currentValue = currency2Rates.ZEC.USD;

                }

                catch (Exception e)
                {
                    if (e.Equals("NullReferenceException"))
                        continue;
                }

                //verifies that the thread exists
                if (CryptoCurrencyChart.IsHandleCreated)
                {
                    //invokes the UpdateChart method
                    this.Invoke((MethodInvoker)delegate { UpdateChart(); });
                }

                //Pauses the loop for 10 seconds
                Thread.Sleep(10000);

            }


        }

        private void UpdateChart()
        {

            //Add point to the graph
            CryptoCurrencyChart.Series["CurrencySeries"].Points.AddXY(DateTime.Now.ToString("h:mm:ss tt"), currentValue);

            CurrentValueLabel.Text = currentValue.ToString("f2");

            //If the currentValue reaches a new high
            if (currentValue > currentHigh)
                currentHigh = currentValue;

            //If the currentValue reaches a new low
            if (currentValue < currentLow)
                currentLow = currentValue;

            //Generate an alert if the currentValue rises above the value specified by the user
            if (currentValue > userDefinedHigh)
                MessageBox.Show(("Attention the Cryptocurrency has risen above " + userDefinedHigh));

            //Generate an alert if the currentValue rises above the value specified by the user
            if (currentValue < userDefinedLow)
                MessageBox.Show(("Attention the Cryptocurrency has fallen bellow " + userDefinedLow));

            //Check whether the currentValue is rising or falling
            if (previousValue > currentValue)
                isRising = false;
            else
                isRising = true;

            //Display wheter the currentValue is rising or falling
            if (isRising)
            {
                Trend.Text = ("Rising");
                Trend.BackColor = Color.FromArgb(0,255,0);
            }
            else
            {
                Trend.Text = ("Falling");
                Trend.BackColor = Color.FromArgb(255, 0, 0);
            }

            HighLabel.Text = currentHigh.ToString("f2");
            LowLabel.Text = currentLow.ToString("f2");

            //Assign the current value as the previous value
            previousValue = currentValue;

        }

        //get the JSON data
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

        private void StartButton_Click(object sender, EventArgs e)
        {
            //clears the old data from the chart
            CryptoCurrencyChart.Series["CurrencySeries"].Points.Clear();
            //kills the previous thread
            if (cryptoCurrency2Thread != null)
                cryptoCurrency2Thread.Abort();
            //creates a new thread
            cryptoCurrency2Thread = new Thread(new ThreadStart(this.getRLTData));
            cryptoCurrency2Thread.IsBackground = true;
            cryptoCurrency2Thread.Start();
            StartButton.Text = "Refresh";
        }

        private void PickBitcoin_CheckedChanged(object sender, EventArgs e)
        {
            if (PickBitcoin.Checked)
            {
                //uses the url for the new currency, and refreshes the program
                currencyType = 'b';
                currencyURL = get.URL(currencyType);
                StartButton.PerformClick();
            }
        }

        private void PickEthereum_CheckedChanged(object sender, EventArgs e)
        {
            if (PickEthereum.Checked)
            {
                //uses the url for the new currency, and refreshes the program
                currencyType = 'e';
                currencyURL = get.URL(currencyType);
                StartButton.PerformClick();
            }
        }

        private void PickLitecoin_CheckedChanged(object sender, EventArgs e)
        {
            if (PickLitecoin.Checked)
            {
                //uses the url for the new currency, and refreshes the program
                currencyType = 'l';
                currencyURL = get.URL(currencyType);
                StartButton.PerformClick();
            }
        }

        private void PickDash_CheckedChanged(object sender, EventArgs e)
        {
            if (PickDash.Checked)
            {
                //uses the url for the new currency, and refreshes the program
                currencyType = 'd';
                currencyURL = get.URL(currencyType);
                StartButton.PerformClick();
            }
        }

        private void PickZec_CheckedChanged(object sender, EventArgs e)
        {
            if (PickZec.Checked)
            {
                //uses the url for the new currency, and refreshes the program
                currencyType = 'z';
                currencyURL = get.URL(currencyType);
                StartButton.PerformClick();
            }
        }

        private void UserHighTextBox_TextChanged(object sender, EventArgs e)
        {
             Double.TryParse(UserHighTextBox.Text,out userDefinedHigh);
        }

        private void UserLowTextBox_TextChanged(object sender, EventArgs e)
        {
             Double.TryParse(UserLowTextBox.Text,out userDefinedLow);
        }
    }
}
