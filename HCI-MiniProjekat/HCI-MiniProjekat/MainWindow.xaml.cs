using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HCI_MiniProjekat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public LineChart LineChart { get; set; }
        public CandlestickChart candlestickChart { get; set; }

        public List<TimeSeries> chartValues { get; set; }

        public TableWindow tableWindow { get; set; }

        public Dictionary<string, List<TimeSeries>> tableData { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Uri uri = new Uri("../../exchange-rate.png", UriKind.RelativeOrAbsolute);
            this.Icon = BitmapFrame.Create(uri);

            List<Currency> currencies = CsvReader.readCSVfile();
            fromCurrency.ItemsSource = currencies;
            toCurrency.ItemsSource = currencies;

            cbPeriod.ItemsSource = new[] {"Intraday", "Daily", "Weekly", "Monthly"};
            cbAtributes.ItemsSource = new[] { "low", "high", "open", "close" };
            cbInterval.ItemsSource = new[] { "1min","5min", "15min", "30min", "60min" };

            LineChart = new LineChart();
            candlestickChart = new CandlestickChart();
            tableData = new Dictionary<string, List<TimeSeries>>();
            //DataContext = this;
        }

        private void cbPeriod_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbPeriod.SelectedValue.ToString() != "Intraday")
            {
                cbInterval.SelectedItem = null;
                cbInterval.IsEnabled = false;
            }
            else
            {
                cbInterval.IsEnabled = true;
            }
        }


        private void btnDraw_Click(object sender, RoutedEventArgs e)
        {
            if(fromCurrency.SelectedValue != null && toCurrency.SelectedValue != null && cbPeriod.SelectedValue!= null && cbAtributes.SelectedValue!=null)
            {
                string fromCurrencyStr = fromCurrency.SelectedValue.ToString();
                string fromShort = fromCurrencyStr.Split(' ')[0];
                string toCurrencyStr = toCurrency.SelectedValue.ToString();
                string toShort = toCurrencyStr.Split(' ')[0];
                string periodStr = cbPeriod.SelectedValue.ToString();
                string intervalStr = "";
                string atributeStr = cbAtributes.SelectedValue.ToString();
                if(periodStr == "Intraday")
                {
                    intervalStr = cbInterval.SelectedValue.ToString();
                }

                chartValues = DataConverter.getData(fromShort, toShort, periodStr, intervalStr, atributeStr);
                if(chartValues == null)
                {
                    MessageBox.Show("Something went wrong.Try again.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    LineChart.draw(chartValues,fromShort,toShort,periodStr,atributeStr);
                    candlestickChart.draw(chartValues, fromShort, toShort, periodStr, atributeStr);
                    if(!tableData.Keys.Contains(fromShort + "-" + toShort))
                    {
                        tableData.Add(fromShort+"-"+toShort,chartValues);
                    }
                    
                }
                
            }
            else
            {
                MessageBox.Show("Invalid input.","Alert",MessageBoxButton.OK,MessageBoxImage.Error);
                
            }

            DataContext = this;

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            LineChart.clear();
            candlestickChart.clear();
            if(tableWindow != null)
            {
                tableData.Clear();
                tableWindow.table.ItemsSource = null;
                tableWindow.cbPair = null;
            }
        }

        private void btnTable_Click(object sender, RoutedEventArgs e)
        {
            tableWindow = new TableWindow(tableData);
            tableWindow.Show();
        }
    }
}
