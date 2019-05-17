using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace CompanyManager
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
            // Initialize and display data:
            this.allData = DataLoader.Load();
            lbCompanies.ItemsSource = allData.Companies;
        }

        private void handleCompanyCodeChange(string code)
        {
            var companies = ((IList<Company>)lbCompanies.ItemsSource);
            var selectedCompany = companies.First(c => c.Code == code);
            var selectedIndex = companies.IndexOf(selectedCompany);
            lbCompanies.SelectedIndex = selectedIndex;
        }

        private void LbCompanies_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var company = ((Company)e.AddedItems[0]);
            lblSelectedCompanyName.Content = company.Name;
        }
    }
}
