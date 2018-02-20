using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencyApp
{
    class HistoricalDataJSON
    {
        public string Response { get; set; }
        public int Type { get; set; }
        public bool Aggregated { get; set; }
        public Datum[] Data { get; set; }
        public int TimeTo { get; set; }
        public int TimeFrom { get; set; }
        public bool FirstValueInArray { get; set; }
        public Conversiontype ConversionType { get; set; }
    }

    public class Conversiontype
    {
        public string type { get; set; }
        public string conversionSymbol { get; set; }
    }

    public class Datum
    {
        public int time { get; set; }
        public float close { get; set; }
        public float high { get; set; }
        public float low { get; set; }
        public float open { get; set; }
        public float volumefrom { get; set; }
        public float volumeto { get; set; }
    }

}
