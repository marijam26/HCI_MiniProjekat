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
using System.Windows.Shapes;

namespace HCI_MiniProjekat
{
    /// <summary>
    /// Interaction logic for TableWindow.xaml
    /// </summary>
    public partial class TableWindow : Window
    {
        public List<TimeSeries> tableElements { get; set; }

        public Dictionary<string, List<TimeSeries>> tableValues { get; set; }

        public TableWindow(Dictionary<string, List<TimeSeries>> values)
        {
            InitializeComponent();

            Uri uri = new Uri("../../exchange-rate.png", UriKind.RelativeOrAbsolute);
            this.Icon = BitmapFrame.Create(uri);
            tableValues = values;

            cbPair.ItemsSource = values.Keys;
            cbPair.SelectedIndex = 0;
            DataContext = this;
        }

        private void cbPair_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedPair = cbPair.SelectedValue.ToString();
            table.ItemsSource = tableValues[selectedPair];
        }

    }
}
