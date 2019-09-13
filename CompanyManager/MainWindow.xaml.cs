using Data;
using InteropLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Tick42;
using Tick42.Windows;

namespace CompanyManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class CompanyService : ICompanyService
        {
            private Action<string> handleCompanyCode;
            public CompanyService(Action<string> handleCompanyCode)
            {
                this.handleCompanyCode = handleCompanyCode;
            }

            public void Dispose()
            {
                this.handleCompanyCode = null;
            }

            public bool ShowCompany(string code)
            {
                Application.Current.Dispatcher.BeginInvoke(new Action(() =>
                {
                    this.handleCompanyCode(code);
                }));
                return true;
            }
        }

        private AllData allData;

        public MainWindow()
        {
            InitializeComponent();
            // Initialize and display data:
            this.allData = DataLoader.Load();
            lbCompanies.ItemsSource = allData.Companies;

            //Initialize Glue42 and register the current app:
            var applicationName = "CompanyManager";
            var glue = new Glue42();
            glue.Initialize(applicationName);

            //Instantiate the service instance and register to Glue42:
            var companyService = new CompanyService((code) => { this.handleCompanyCodeChange(code); });
            glue.Interop.RegisterService<ICompanyService>(companyService);

            // Initialize Window Stickiness and read from config:
            var swOptions = glue.GlueWindows?.GetStartupOptions() ?? new GlueWindowOptions();
            glue.GlueWindows?.RegisterWindow(this, swOptions);
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
