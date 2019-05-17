using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Client
    {
        public Client(string name, IList<string> portfolio)
        {
            this.Name = name;
            this.Portfolio = portfolio;
        }

        public string Name
        {
            get;
            private set;
        }

        public IList<string> Portfolio
        {
            get;
            private set;
        }
    }
}
