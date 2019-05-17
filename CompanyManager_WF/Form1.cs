using System.Windows.Forms;
using Data;

namespace CompanyManager_WF
{
    public partial class Form1 : Form
    {
        private AllData data;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.data = DataLoader.Load();
            this.lbCompanies.DataSource = this.data.Companies;
        }

        private void lbCompanies_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var selectedCompany = (Company)lbCompanies.SelectedItem;
            txtCompanyDetails.Text = string.Format("{0} ({1})", selectedCompany.Name, selectedCompany.Code);
        }
    }
}
