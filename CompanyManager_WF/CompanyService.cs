using InteropLib;
using System;
using System.Windows.Forms;

namespace CompanyManager_WF
{
    internal class CompanyService : ICompanyService
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
            this.handleCompanyCode(code);
            return true;
        }
    }
}
