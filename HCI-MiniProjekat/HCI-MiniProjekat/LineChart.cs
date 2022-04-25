using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Controls;

namespace HCI_MiniProjekat
{
    public partial class LineChart : UserControl
    {
        public SeriesCollection SeriesCollection { get; set; }
        public List<string> labels { get; set; }

        public List<TimeSeries> chartValues { get; set; }

        // public Func<double, string> YFormatter { get; set; }

        public LineChart()
        {
            labels = new List<string>();
            SeriesCollection = new SeriesCollection { };
            chartValues = new List<TimeSeries>();
            //YFormatter = value => value.ToString();
            DataContext = this;
        }

        public void draw(List<TimeSeries> chartValues, string from, string to, string period, string atribute)
        {
            this.chartValues = chartValues;
            if (period == "Intraday")
            {
                this.labels = this.chartValues.Select(x => x.timeStamp.ToString()).ToList();
            }
            else
            {
                this.labels = this.chartValues.Select(x => x.timeStamp.ToShortDateString()).ToList();
            }

            ChartValues<double> values = getValuesByAtribute(atribute);

            LineSeries lines = new LineSeries
            {
                Title = from + "-" + to,
                Values = values,
                PointGeometry = null,
                PointGeometrySize = 15
            };
            SeriesCollection.Add(lines);

        }

        public void clear()
        {
            SeriesCollection.Clear();
            labels.Clear();
        }

        public ChartValues<double> getValuesByAtribute(string atribute)
        {
            if (atribute == "open")
            {
                return new ChartValues<double>(chartValues.Select(x => x.open));
            }
            else if (atribute == "close")
            {
                return new ChartValues<double>(chartValues.Select(x => x.close));
            }
            else if (atribute == "low")
            {
                return new ChartValues<double>(chartValues.Select(x => x.low));
            }
            else if (atribute == "high")
            {
                return new ChartValues<double>(chartValues.Select(x => x.high));
            }

            return null;

        }


    }
}
