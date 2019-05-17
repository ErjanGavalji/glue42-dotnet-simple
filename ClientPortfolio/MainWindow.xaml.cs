using Data;
using InteropLib;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Tick42;

namespace ClientPortfolio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AllData allData;
        private Glue42 glue;
        private ICompanyService companyService;

        public MainWindow()
        {
            InitializeComponent();
            this.allData = DataLoader.Load();
            lbCustomers.ItemsSource = allData.Clients;

            //Initialize Glue42 and register the current app:
            var applicationName = "ClientPortfolio";
            this.glue = new Glue42();
            this.glue.Initialize(applicationName);
            this.companyService = this.glue.Interop.CreateServiceProxy<ICompanyService>();
        }

        private void LbCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var clientPortfolio = ((Client)e.AddedItems[0]).Portfolio;
            lbPortfolio.ItemsSource = this.allData.Companies.Where(c => clientPortfolio.Contains(c.Code));
        }

        private void LbPortfolio_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                var selectedCompanyCode = ((Company)e.AddedItems[0]).Code;
                var result = companyService.ShowCompany(selectedCompanyCode);
            }
        }
    }
}
