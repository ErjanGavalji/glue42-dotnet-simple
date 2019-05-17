using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Data;
using InteropLib;
using Tick42;
using Tick42.StickyWindows;

namespace CompanyManager_WF
{
    public partial class Form1 : Form
    {
        private AllData allData;
        public Form1()
        {
            InitializeComponent();

            this.allData = DataLoader.Load();

            //Initialize Glue42 and register the current app:
            var applicationName = "CompanyManager_WF";
            var glue = new Glue42();
            glue.Initialize(applicationName);

            //Instantiate the service instance and register to Glue42:
            var companyService = new CompanyService((code) => {
                this.Invoke(new MethodInvoker(() => {
                    this.handleCompanyCodeChange(code);
                }));
            });
            glue.Interop.RegisterService<ICompanyService>(companyService);

            // Initialize Window Stickiness and read from config:
            var swOptions = glue.StickyWindows?.GetStartupOptions() ?? new SwOptions();
            glue.StickyWindows?.RegisterWindow(this.Handle, swOptions);
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.lbCompanies.DataSource = this.allData.Companies;
        }

        private void lbCompanies_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var selectedCompany = (Company)lbCompanies.SelectedItem;
            txtCompanyDetails.Text = string.Format("{0} ({1})", selectedCompany.Name, selectedCompany.Code);
        }

        private void handleCompanyCodeChange(string code)
        {
            var companies = (IList<Company>)lbCompanies.DataSource;
            var selectedCompany = companies.First(c => c.Code == code);
            var selectedIndex = companies.IndexOf(selectedCompany);
            lbCompanies.SelectedIndex = selectedIndex;
        }

    }
}
