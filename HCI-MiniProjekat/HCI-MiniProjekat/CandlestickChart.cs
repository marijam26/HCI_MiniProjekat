using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Controls;
using System.Windows.Media;

namespace HCI_MiniProjekat
{
    public partial class CandlestickChart : UserControl
    {

        public List<TimeSeries> chartValues { get; set; }
        public SeriesCollection SeriesCollection { get; set; }

        public List<string> labels { get; set; }

        public int counter;

        public CandlestickChart()
        {
            chartValues = new List<TimeSeries>();
            labels = new List<string>();
            SeriesCollection = new SeriesCollection();
            DataContext = this;
            counter = 0;
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

            ChartValues<OhlcPoint> points = new ChartValues<OhlcPoint>();
            foreach(TimeSeries series in chartValues)
            {
                points.Add(new OhlcPoint(series.open,series.high,series.low,series.close));
            }

            SolidColorBrush[] colors = { Brushes.Blue, Brushes.Red, Brushes.Yellow,Brushes.Gray,Brushes.Aqua };

            SeriesCollection.Add(
                new CandleSeries
                {
                    Title = from + "-" + to,
                    Values = points,
                    IncreaseBrush = colors[counter],
                }

            );
            counter++;

        }

        public void clear()
        {
            SeriesCollection.Clear();
            labels.Clear();
            counter = 0;
        }

       

    }
    



    
}
