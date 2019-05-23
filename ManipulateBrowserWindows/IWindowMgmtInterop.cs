using DOT.AGM.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulateBrowserWindows
{
    [ServiceContract(MethodNamespace = "T42.Wnd.")]
    public interface IWindowMgmtInterop : IDisposable
    {
        [ServiceOperation(AsyncIfPossible = true, ExceptionSafe = true)]
        int Create(string name, string url);

        [ServiceOperation(AsyncIfPossible = true, ExceptionSafe = true)]
        object Execute(string command, string windowId, Object options);
    }
}
