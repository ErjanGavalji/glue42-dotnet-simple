using Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace ClientPortfolio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AllData allData;

        public MainWindow()
        {
            InitializeComponent();
            this.allData = DataLoader.Load();
            lbCustomers.ItemsSource = allData.Clients;
        }

        private void LbCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var clientPortfolio = ((Client)e.AddedItems[0]).Portfolio;
            lbPortfolio.ItemsSource = this.allData.Companies.Where(c => clientPortfolio.Contains(c.Code));
        }
    }
}
