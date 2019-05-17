using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Company
    {
        public Company(string name, string code, string url)
        {
            this.Name = name;
            this.Code = code;
            this.Url = url;
        }

        public string Name
        {
            get;
            private set;
        }

        public string Code
        {
            get;
            private set;
        }

        public string Url
        {
            get;
            private set;
        }
    }
}
