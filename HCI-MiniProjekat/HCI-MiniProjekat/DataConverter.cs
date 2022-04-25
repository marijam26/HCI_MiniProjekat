using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace HCI_MiniProjekat
{
    public static class DataConverter
    {


        public static List<TimeSeries> getData(string from, string to, string period, string interval, string atribute)
        {


            List<TimeSeries> chartValues = new List<TimeSeries>();

            string functionStr = "FX_" + period.ToUpper();
            string QUERY_URL = "";
            string periodForJson = "";
            if (period == "Intraday")
            {
                QUERY_URL = $"https://www.alphavantage.co/query?function={functionStr}&from_symbol={from}&to_symbol={to}&interval={interval}&apikey=5EXGHV7L760GFYCT";
                periodForJson = interval;
            }
            else
            {
                QUERY_URL = $"https://www.alphavantage.co/query?function={functionStr}&from_symbol={from}&to_symbol={to}&apikey=5EXGHV7L760GFYCT";
                periodForJson = period;
            }

            try
            {
                Uri queryUri = new Uri(QUERY_URL);

                using (WebClient client = new WebClient())
                {


                    JavaScriptSerializer js = new JavaScriptSerializer();
                    dynamic json_data = js.Deserialize(client.DownloadString(queryUri), typeof(object));

                    var data = json_data[$"Time Series FX ({periodForJson})"];

                    foreach (var item in data)
                    {
                        string time = item.Key;
                        DateTime timeStamp;

                        bool isDateTime = DateTime.TryParse(time, out timeStamp);
                        if (!isDateTime)
                        {
                            throw new Exception("Nije datetime oblika.");
                        }

                        Dictionary<string, object> volumes = item.Value;

                        TimeSeries ts = new TimeSeries(timeStamp, Double.Parse(volumes["1. open"].ToString()), Double.Parse(volumes["2. high"].ToString()), Double.Parse(volumes["3. low"].ToString()), Double.Parse(volumes["4. close"].ToString()));
                        chartValues.Add(ts);

                    }

                    return chartValues;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }
    }

    public class TimeSeries
    {
        public DateTime timeStamp { get; set; }

        public double open { get; set; }

        public double close { get; set; }

        public double low { get; set; }

        public double high { get; set; }

        public TimeSeries(DateTime time, double open, double close, double low, double high)
        {
            this.timeStamp = time;
            this.open = open;
            this.close = close;
            this.low = low;
            this.high = high;
        }
    }
}
